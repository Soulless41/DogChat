import socket
import threading

HOST = '0.0.0.0'
PORT = 5000
clients = []

def broadcast(message_bytes):
    """Gelen mesajı bağlı olan İSTİSNASIZ herkese gönderir."""
    if not message_bytes.endswith(b'\n'):
        message_bytes += b'\n'
    
    print(f"Yayınlanıyor: {message_bytes.decode('utf-8').strip()}")
    
    for client in clients[:]: # Liste kopyası üzerinden dönmek daha güvenlidir
        try:
            client.sendall(message_bytes)
        except:
            clients.remove(client)

def handle_client(conn, addr):
    try:
        # Kullanıcı adını al
        username = conn.recv(1024).decode('utf-8').strip()
        broadcast(f"Sistem: {username} bağlandı.\n".encode('utf-8'))
        
        while True:
            data = conn.recv(1024)
            if not data:
                break
            # Gelen mesajı herkese (gönderen dahil) geri yolla
            broadcast(data)
    except:
        pass
    finally:
        if conn in clients:
            clients.remove(conn)
        conn.close()

def start():
    server = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    server.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1) # Portu hemen tekrar açabilmek için
    server.bind((HOST, PORT))
    server.listen(5)
    print(f"[*] Sunucu {PORT} portunda hazır...")
    
    while True:
        conn, addr = server.accept()
        clients.append(conn)
        threading.Thread(target=handle_client, args=(conn, addr), daemon=True).start()

if __name__ == "__main__":
    start()