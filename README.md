Benjamin Shirk Assessment ReadME
--------------------------------

This assessment has 2 console applications. (.NET 6)
-------------------------------------------

1. RabbitMQ_Sender
2. RabbitMQ_Receiver
-------------------------------------------

RabbitMQ_Sender is where the user will enter their name and will send a required message to the queue.
RabbitMQ_Sender consists of a Person class/object, WorkerClass, and the Main Class.
RabbitMQ_Sender has 2 libraries. 
1. RabbitMQ_Library which does the connection to the RabbitMQ server and sending to the queue.
2. WorkerClassLibrary_Test is where the unit testing for this console application will happen.
-------------------------------------------------------------------------------------------------

RabiitMQ_Receiver is where the user get the message from the queue and output the required message.
RabiitMQ_Receiver consists of just Main Class.
RabbitMQ_Receiver has 2 libraries.
1. RabbitMQ_Library which does the connection to the RabbitMQ server and receiving from the queue.
2. ReceiverLibrary_Test is where the unit testing for this console application will happen.
---------------------------------------------------------------------------------------------------
