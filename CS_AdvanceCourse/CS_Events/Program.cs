using CS_Events;
Console.WriteLine("Events in C#");


Video video = new Video() { titleOfVideo = "King" };


VideoEncoder videoEncoder = new VideoEncoder(); // Publisher
MessageSender messageSender = new MessageSender(); // Receiver
SendMail sendMail = new SendMail();

videoEncoder.VideoEncoded += messageSender.OnVideoEncoded;
videoEncoder.VideoEncoded += sendMail.OnVideoEncoded;



videoEncoder.Encode(video); 






