# Lab 6 - Kafka Integration

## Objective

Implement a simple Kafka Chat Application using C#.

## Files

- Producer.cs
- Consumer.cs
- Program.cs

## Concepts

- Kafka Producer
- Kafka Consumer
- Topics
- Brokers
- Streaming Messages

## Kafka Commands

Start Zookeeper

```
zookeeper-server-start.bat ../../config/zookeeper.properties
```

Start Kafka Server

```
kafka-server-start.bat ../../config/server.properties
```

Create Topic

```
kafka-topics.bat --create --zookeeper localhost:2181 --replication-factor 1 --partitions 1 --topic chat-message
```

Producer

```
kafka-console-producer.bat --broker-list localhost:9092 --topic chat-message
```

Consumer

```
kafka-console-consumer.bat --bootstrap-server localhost:9092 --topic chat-message --from-beginning
```