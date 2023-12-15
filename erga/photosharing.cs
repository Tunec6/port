using System.Net.Sockets;
using System.Text;

using var tcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); 
try{
    await tcpClient.ConnectAsync("192.168.220.139", 1777);
    while(true)
    {

        string path = ".img/123.jpg";

        byte[] reqestData = File.ReadAllBytes(path);

        await tcpClient.SendAsync(reqestData);

        Console.WriteLine("Изображение отправленно!");
        
    }
}
catch (Exception ex){
    Console.WriteLine(ex.Message);
}


var a = 1