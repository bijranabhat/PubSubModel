# PubSubModel
Topic-based publish-subscribe system -(using C# on .NET) which filters system logs based on their nature. The logs are streamed through Apache Kafka and stored in Active MQ while being passed to the subscribers. The publishers publish the logs under specific buckets(s) (which if not present, Kafka creates one). 
