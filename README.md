# learning_resources

- [Backend Interview process & questions at a startup](Backend_interview_process.md#interview-process-at-a-startup)
- [Videos](README.md#videos)
- [Datastructures and algorithms](README.md#datastructures-and-algorithms)
- [System design](README.md#system-design)


## Videos
1. [8 design patterns](https://www.youtube.com/watch?v=tAuRQs_d9F8) every developer should know

1. 10 [System design concepts](https://www.youtube.com/watch?v=i53Gi_K3o7I) explained consisely

1. What is the difference between a [process and a thread](https://www.youtube.com/watch?v=4rLW7zg21gI&list=PLCRMIe5FDPseVvwzRiCQBmNOVUIZSSkP8&index=8)?

2. What is [HTTPS and TLS](https://www.youtube.com/watch?v=j9QmMEWmcfo&list=PLCRMIe5FDPseVvwzRiCQBmNOVUIZSSkP8&index=9)?

3. [What happens](https://www.youtube.com/watch?v=AlkDbnbv7dk&list=PLCRMIe5FDPseVvwzRiCQBmNOVUIZSSkP8&index=10) when you type a URL into your browser?

</details>

## Datastructures and algorithms
[bestresources](https://bestresources.co/resource/the-interview-study-guide-for-software-engineers-by-benjamin-rogojan--qvf019) - collected links about this DSA

<details>
    <summary>Tree Traversal recursive - DFS</summary>

```csharp
class Node {
    public int data;
    public Node left, right;
 
    public Node(int data)
    {
        data = data;
        left = right = null;
    }
}Videos
 
public class BinaryTree {
    // Root of Binary Tree
    Node root;
 
    BinaryTree() { root = null; }
 
    /* Given a binary tree, print its nodes in inorder*/
    void printInorder(Node node)
    {
        if (node == null)
            return;
 
        /* first recur on left child */
        printInorder(node.left);
 
        /* process current node */
        Console.Write(node.data + " ");
 
        /* now recur on right child */
        printInorder(node.right);
    }
```

</details>

<details>
    <summary>Tree Traversal iterative - BFS</summary>

```csharp
public class Node {
    public int data;
    public Node left, right;
 
    public Node(int data)
    {
        data = data;
        left = null;
        right = null;
    }
}

public class BinaryTree {
    Node root;

    void printLevelOrder()
    {
        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(root);
        while (queue.Count != 0) {
 
            //Process node
            Node tempNode = queue.Dequeue();
            Console.Write(tempNode.data + " ");
 
            /*Enqueue left child */
            if (tempNode.left != null) {
                queue.Enqueue(tempNode.left);
            }
 
            /*Enqueue right child */
            if (tempNode.right != null) {
                queue.Enqueue(tempNode.right);
            }
        }
    }
}
```

</details>

<br>

## System design

### Networking concepts

__TCP/IP:__ 
Transmission Control Protocol/Internet Protocol is the foundation of the internet. TCP is responsible for ensuring reliable transmission of data over a network, while IP is responsible for routing data between networks.


__HTTP:__ Hypertext Transfer Protocol is used for transmitting data over the internet. It is used for communication between web servers and web clients.


__DNS:__ Domain Name System is used to map domain names to IP addresses. DNS servers translate human-readable domain names into IP addresses that machines can understand.


__Load Balancing:__ The process of distributing incoming traffic across multiple servers to ensure that no single server is overloaded. Load balancing can be done using various algorithms such as round-robin, least connections, and IP hash.


__Caching:__ Storing frequently accessed data in a cache to reduce the number of requests made to a server. Caching can be done at various levels such as browser cache, CDN cache, and server cache.


__CDNs:__ Content Delivery Networks are networks of servers that are distributed geographically to deliver content to users with high availability and performance.


__Latency vs. Bandwidth:__ Latency refers to the time it takes for a request to travel from the client to the server and back, while bandwidth refers to the amount of data that can be transmitted over a network in a given amount of time.


__Routing:__ The process of selecting a path for network traffic to travel from the source to the destination. Routing can be done using various algorithms such as distance vector routing, link-state routing, and path vector routing.


__VPN:__ Virtual Private Network is a secure connection between two devices over the internet. VPNs are used to protect data and provide secure remote access to resources.
__Frewall:__ A security system that monitors and controls incoming and outgoing network traffic based on predetermined security rules. Firewalls are used to protect networks from unauthorized access and malicious traffic.

__OSI model:__ The Open Systems Interconnection model is a conceptual framework used to describe the communication between different computer systems. It is organized into seven layers, each responsible for a different aspect of network communication.

__NAT:__ Network Address Translation is a technique used to map public IP addresses to private IP addresses. NAT allows multiple devices on a private network to share a single public IP address.

__SSL/TLS:__ Secure Sockets Layer/Transport Layer Security is a protocol used to provide secure communication over the internet. SSL/TLS uses encryption to protect data in transit and ensure that it is not intercepted or tampered with.

__BGP:__ Border Gateway Protocol is a routing protocol used to exchange routing information between different networks on the internet. BGP is used by internet service providers to route traffic between networks.
VLAN: Virtual Local Area Network is a logical grouping of network devices that are physically separate but appear as if they are on the same network. VLANs are used to segment networks for security and management purposes.

__Traceroute:__ A network diagnostic tool used to trace the path that a packet takes from the source to the destination. Traceroute sends packets with increasing time-to-live values and reports the IP addresses of the routers along the path.

__IPv6:__ Internet Protocol version 6 is the latest version of the Internet Protocol. IPv6 provides a larger address space than IPv4 and improves security and performance.

__ICMP:__ Internet Control Message Protocol is used for error reporting and network diagnostics. ICMP messages are sent by network devices to report errors or request information about the network.

__NAT traversal:__ The process of allowing traffic to pass through a NAT device. NAT traversal techniques include STUN, TURN, and ICE.
Network segmentation: The process of dividing a network into smaller subnetworks for security and management purposes. Network segmentation can be done using VLANs, subnets, or firewalls.

### System design concepts

__Scalability:__ Scalability refers to the ability of a system to handle increasing amounts of load or traffic by adding more resources. A scalable system can handle more users, more data, and more requests without significant performance degradation. For example, a scalable e-commerce website should be able to handle a sudden surge in traffic during a flash sale without crashing or becoming slow.

__Availability:__ Availability is the measure of how often a system is accessible and usable. High availability means that a system is available most of the time, with minimal downtime. For example, a highly available cloud storage service should be accessible to users at all times, even if some servers fail or undergo maintenance.

__Reliability:__ Reliability is the measure of how often a system functions as expected without failures or errors. A reliable system should be able to recover from failures and maintain data integrity. For example, a reliable banking system should not lose or corrupt customer data, and should be able to recover from hardware failures or network outages.

__Latency:__ Latency is the time it takes for a system to respond to a request. Low latency is important for real-time systems, such as online games, video streaming, and financial trading platforms. For example, a low-latency trading platform should be able to execute trades quickly, in order to take advantage of market opportunities.

__Throughput:__ Throughput is the number of requests a system can handle in a given amount of time. High throughput is important for systems that need to process large amounts of data, such as databases, data warehouses, and big data analytics platforms. For example, a high-throughput data processing system should be able to analyze large volumes of data quickly, in order to generate insights for businesses.

__Consistency:__ Consistency is the degree to which data is the same across different parts of a system. In a consistent system, all nodes have the same data at the same time. Consistency can be achieved by using distributed databases, implementing consensus algorithms, and using version control. For example, a consistent messaging system should ensure that all users see the same messages in the same order, regardless of which server they are connected to.

__Partitioning:__ Partitioning is the process of dividing a system into smaller components or partitions. Partitioning can help improve scalability and availability by distributing data and processing across multiple servers. Partitioning can be done by using sharding, horizontal scaling, and vertical scaling. For example, a partitioned database can store customer data for different regions or countries in different partitions, to improve performance and reduce latency.

__Caching:__ Caching is the process of storing frequently accessed data in a cache to reduce the number of requests made to a system. Caching can help improve latency and throughput by reducing the amount of time it takes to access data. Caching can be implemented using in-memory caches, distributed caches, and content delivery networks (CDNs). For example, a web browser can cache frequently accessed website data, such as images and scripts, to reduce the time it takes to load the page.

__Load balancing:__ Load balancing is the process of distributing incoming traffic across multiple servers to ensure that no single server is overloaded. Load balancing can help improve scalability, availability, and throughput by distributing requests across multiple servers. Load balancing can be done using hardware load balancers, software load balancers, and DNS load balancing. For example, a load-balanced web server cluster can distribute incoming traffic across multiple servers, to improve response times and reduce the risk of server crashes.

__Microservices:__ Microservices is an architectural pattern that involves breaking down a large application into smaller, independent services that can be deployed and scaled separately. Each microservice should have its own database, API, and user interface. Microservices can help improve scalability, availability, and resilience by allowing developers to make changes and deploy updates to individual services without affecting the entire system. For example, a social media platform can be broken down into microservices for user authentication, friend requests, notifications, and news feeds.

__Service-oriented architecture (SOA):__ Service-oriented architecture is an architectural pattern that involves creating reusable services that can be accessed by multiple applications or systems. SOA allows applications to communicate with each other by using standardized interfaces and protocols. SOA can help improve interoperability, flexibility, and reusability by decoupling services from specific applications or systems. For example, a payment gateway service can be used by multiple e-commerce websites to process payments, without having to implement their own payment processing system.

__Message queues:__ Message queues are a type of middleware that enables asynchronous communication between applications or services. Message queues can help improve scalability, availability, and resilience by decoupling services and allowing them to operate independently. Message queues can also help ensure message delivery and provide message ordering and filtering capabilities. For example, a message queue can be used to handle user registration requests for an e-commerce website, with each request being processed by a separate microservice.

__Event-driven architecture (EDA):__ Event-driven architecture is an architectural pattern that involves reacting to events or messages that are generated by the system or external sources. EDA can help improve scalability, availability, and responsiveness by allowing systems to react quickly to changes or events. EDA can also help simplify system design and reduce coupling between components. For example, an event-driven system can be used to detect fraud or suspicious activity in real-time, by analyzing user behavior and triggering alerts or notifications.

__MapReduce:__ MapReduce is a programming model and framework for processing large amounts of data in parallel across multiple nodes. MapReduce can help improve throughput and scalability by dividing data processing into smaller tasks that can be executed in parallel. MapReduce also provides fault tolerance and data locality, by ensuring that tasks are executed on nodes where the data is located. For example, MapReduce can be used to analyze log files or customer data for a large online retailer, to generate insights for marketing and product development.

__Containerization:__ Containerization is a method of packaging software applications and their dependencies into lightweight, portable containers that can be deployed and run consistently across different environments. Containerization can help improve portability, scalability, and reliability by isolating applications from the underlying infrastructure and ensuring consistent dependencies. Containerization can be done using container engines such as Docker or Kubernetes. For example, a containerized microservice can be easily deployed and scaled across multiple servers, without having to worry about compatibility or dependencies.

__Serverless computing:__ Serverless computing is a cloud computing model where applications are run on demand in response to specific events or triggers, without the need for managing infrastructure or servers. Serverless computing can help improve scalability, availability, and cost efficiency by allowing developers to focus on application logic, rather than infrastructure management. Serverless computing can be done using platforms such as AWS Lambda or Google Cloud Functions. For example, a serverless application can be used to process user-generated content, with each content item being processed by a separate function in response to a trigger.

__Content delivery network (CDN):__ A content delivery network is a distributed system of servers that delivers web content to users based on their geographic location, network conditions, and content type. CDNs can help improve performance, scalability, and availability by caching content in edge locations close to users and routing requests to the nearest server. CDNs can also help reduce network latency and bandwidth costs by minimizing the distance between the user and the content. For example, a CDN can be used to deliver images, videos, and other static content for a popular news website, to ensure fast and reliable content delivery to users worldwide.

__Load balancing:__ Load balancing is a technique for distributing traffic across multiple servers or nodes in a network, to improve performance, availability, and scalability. Load balancing can help prevent server overload, reduce response times, and ensure high availability by redirecting traffic to healthy servers. Load balancing can be done using hardware or software load balancers, such as F5 or HAProxy. For example, a load balancer can be used to distribute incoming requests to multiple instances of a web application, to ensure that each server is used efficiently and that the application remains responsive under heavy load.

__Monitoring and logging:__ Monitoring and logging are essential components of system design, as they allow developers to track system performance, detect issues, and troubleshoot problems. Monitoring involves collecting and analyzing metrics and events from various system components, such as servers, applications, and networks. Logging involves capturing and storing system events, errors, and user actions for later analysis and troubleshooting. Monitoring and logging can be done using tools such as Prometheus, Grafana, or ELK. For example, monitoring and logging can be used to track system uptime, response times, error rates, and user activity for an e-commerce website, to ensure optimal performance and user experience.

[Sytem design primer](https://github.com/donnemartin/system-design-primer#study-guide) - start here

[Best handpicked system design](https://bestresources.co/resource/best-handpicked-system-design-interesting-reads-qvbimi) - interesting reads

[Actual system design interview questions](https://bestresources.co/resource/system-design-actual-interview-questions-qvbj2c) - Videos, articles about their solutions

[Example mock interviews](https://www.youtube.com/@tryexponent) - Mock interviews, anything that can help you land a good job in tech

https://www.hiredintech.com/classrooms/system-design/lesson/61

https://www.reddit.com/r/leetcode/comments/uc3zex/what_are_good_resources_for_system_design/




