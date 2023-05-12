# Interview process at a startup

These questions were collected by a lead-backend engineer who did the hiring at a gaming startup. I was asked several of these including the coding challenges.

A lot of the answers I generated with Chat-GPT (pronounce: chat gipitty) Not mindlessly might I add, but still use it with caution.

## Adaptive interview process
The following interview questionnaire is created to adaptively assign questions for the candidate. The topics order is followed by the actual conversation, so this documentation has to be considered as a guide only. The interview consists of three parts:
- __Cracking the Egg:__ First we aim to guide the candidate to a little more relaxed state as it’ll help during the whole process.
- __Show us what you got!:__ In the second part we give the candidate one or two short algorithms to implement where we can track the
thread of thought.
- __Do you know…?:__ Lastly we bombard the candidate with several theoretical and lexical questions trying to find the boundaries in various topics.

## Cracking the Egg
__Describe your typical work day!__

__If you’d have infinite resources, how would you improve your last assignment tasks?__

__What do you consider your biggest achievement?__

__How do you inform yourself about the latest technologies? / How do you educate yourself?__

__How would you describe the SDLC you have been working with? What would be the ideal one?__

__Which methodology have you been working with?__

<br>

__What are the main points of a Waterfall methodology?__

Waterfall methodology is often used for large, well-defined projcts with a clear set of requirements. The process is characterized by its linear, sequential flow, with each stage building upon the previous one, and with little or no overlap between stages. The key advantage of Waterfall is its predictability, making it ideal for projects where the requirements are well understood and unlikely to change.
- Requirements gathering and analysis: This stage involves gathering the requirements for the software from stakeholders and analyzing the information to determine what the software needs to do.
- Design: This stage involves creating a detailed design for the software, including architectural design, interface design, and database design.
- Implementation: This stage involves writing code and building the software based on the design.
Testing: This stage involves testing the software to ensure it meets the requirements and fixing any bugs or issues found during testing.
- Deployment: This stage involves deploying the software to a production environment, where it can be used by end-users.
Maintenance: This stage involves maintaining and updating the software to fix bugs and add new features.

__What does Agile mean to you?__

Agile emphasizes the flexibility and adaptability of software development processes, allowing teams to respond quickly to changes in requirements or market conditions. Agile is a response to the rigid, prescriptive approaches of traditional software development methodologies, such as Waterfall. It is based on the Agile Manifesto, which outlines a set of principles for software development that prioritize delivering value to customers and embracing change. Agile approaches include Scrum, Kanban, and Lean. Agile methodologies are used to build software in an iterative, incremental manner, with a focus on continuous improvement and collaboration between team members.

__Which Agile methodology have you met?__
Kanban, Scrum

__How would you organise a KANBAN/SCRUM development?__

Scrum
- Form a cross-functional team: Assemble a team with all the skills needed to complete a project, including developers, designers, and testers.
- Prioritize a backlog: Create a prioritized list of tasks, called a backlog, that the team will work on.
- Plan sprints: Plan short, iterative development cycles, called sprints, to deliver working software incrementally.
- Hold daily stand-up meetings: Hold daily stand-up meetings to discuss progress, identify obstacles, and coordinate work.
- Review and adjust the process: After each sprint, review the progress made and make adjustments to the process as needed to ensure continuous improvement.

Kanban

- Visualize the workflow: Create a visual representation of the work process, such as a whiteboard or digital board, to show the flow of work from start to finish.
- Limit work in progress: Set limits on the number of tasks that can be worked on simultaneously to prevent bottlenecks and increase focus.
- Manage flow: Monitor the flow of work and make adjustments as needed to keep the process running smoothly.
- Make process policies explicit: Define the rules and policies for the process to ensure that everyone is working in a consistent and predictable manner.
- Implement feedback loops: Encourage feedback from team members and stakeholders to continuously improve the process.


__What kind of version control systems have you been working with?__
GIT

__What is the difference between Git and TFS?__

Git is a version control technology that enables you to version your codebases with the opportunity to revert, merge code.
TFS stands for Team Foundation Server is a code repository with version control and the ability to track code changes, an integrated CI/CD tool, that builds and deploys your code and provides project management tools to be able to manage any software development task.


- Centralized vs Distributed: TFS is a centralized version control system, meaning that there is a single source of truth, or "central repository" that all team members check code into and get updates from. Git, on the other hand, is a distributed version control system, where each developer's local repository contains the entire history of the project, allowing for offline work and more flexible collaboration.
- Branching and Merging: Git has a more flexible branching and merging model compared to TFS. In Git, branching is cheap and easy, allowing developers to create multiple branches for different features, bug fixes, etc. TFS has a similar concept, but it is more heavyweight, requiring more steps and administrative privileges.

<br>


__What is the difference between a Merge and a Rebase?__


Merge

Combines multiple branch histories into one, resulting in a new merge commit. This method maintains a clear history of changes and is useful when working with multiple developers on the same code base.

Rebase

On the other hand, replays the changes from a branch onto another branch, resulting in a linear history. This method discards the original branch and its history and is useful when you want to integrate changes from one branch into another without creating a merge commit.

In general, a Merge is used for preserving history and collaboration, while a Rebase is used for creating a linear history and preserving a clean branch structure.

<br>

__While you are working on the code, how do you protect the already implemented functionalities?__

Code version control
- Use version control systems like Git to keep track of changes in the codebase, maintain a history of modifications, and easily revert to previous versions of the code.

Branching strategies
- Use branching strategies like GitFlow or Feature Branching to isolate new code changes and keep them separate from the main codebase. This prevents new changes from breaking existing functionalities.

Code reviews
- Have other team members review the code changes before they are merged into the main codebase. This ensures that new code changes meet the coding standards and do not break existing functionalities.

Automated testing
- Use automated testing tools like JUnit or TestNG to write test cases for new and existing functionalities. This helps to catch bugs and ensure that existing functionalities are not broken by new code changes.

Continuous Integration and Continuous Deployment (CI/CD)
- Implement a CI/CD pipeline to automatically build, test, and deploy code changes. This helps to catch bugs and ensure that new code changes do not break existing functionalities.

__What does a “unit“ mean for you, when you are working with Unit Tests?__

Defining a “unit” is a collective decision for the people, company or project owners which represents the smallest testable code section that needs to be tested. Some companies don’t write unit tests for every class/every function but only a larger piece of code. It can vary due to competency factors as well, a junior is more likely to test the smaller code section to make sure it works.

__Which Unit Test frameworks do you have experience with?__

XUnit - Home > xUnit.net

__How do you handle dependencies, when you’d like to isolate a logic?__

I don’t know
Using interfaces and Dependency injection

__What kind of mocking frameworks are you familiar with?__

Moq

__What is the main difference between a mock and a stub?__

__Stub:__ 
I believe the biggest distinction is that a stub you have already written with predetermined behavior. So you would have a class that implements the dependency (abstract class or interface most likely) you are faking for testing purposes and the methods would just be stubbed out with set responses. They would not do anything fancy and you would have already written the stubbed code for it outside of your test.

`initialise -> set expectations -> exercise -> verify pattern to testing`

```csharp
public class DatabaseStub : IDatabase
{
    public int GetData(string key)
    {
        return 42;
    }
}
```

__Mock:__ A mock is something that as part of your test you have to set up with your expectations. A mock is not set up in a predetermined way so you have code that does it in your test. Mocks in a way are determined at runtime since the code that sets the expectations has to run before they do anything.

`initialise -> exercise -> verify`

```csharp
using Moq;
using System;

namespace MoqExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the mock object
            var mockService = new Mock<IExampleService>();

            // Set up the mock object's behavior
            mockService.Setup(x => x.GetData(It.IsAny<int>()))
                       .Returns("Example Data");

            // Use the mock object in your code
            Console.WriteLine(mockService.Object.GetData(5));
        }
    }

    public interface IExampleService
    {
        string GetData(int id);
    }
}
```

__Similarity between Mocks and Stubs:__ The purpose of both is to eliminate testing all the dependencies of a class or function so your tests are more focused and simpler in what they are trying to prove.

__Have you heard the work “mockicist” before?__

__How would you interpret TDD/BDD? What are the differences?__

__What does FIRST mean? / What is a “good test“ for you?__

__What are the steps of a general testing? / Have you heard about the AAA testing? What does it mean?__

```csharp
// Arrange
var repository = Substitute.For<IClientRepository>();
var client = new Client(repository);

// Act
client.Count();

// Assert
mock.Assert.Equal(15);
```

__What is the test pyramid?__

The idea behind the Test Pyramid is that a well-structured test suite should have more unit tests, which are fast and inexpensive, than integration tests or end-to-end tests, which are slower and more complex. This approach helps to ensure that most of the bugs are caught early in the development process, reducing the cost of fixing them later in the development cycle.

__What do you mean about necessary coverage? What do we cover?__

__What scenarios would you create tests for?__

__What is the difference between an Edge Case and a Corner Case?__

__Edge Case:__ An edge case is a test case that tests the boundaries or limits of the system. Edge cases usually occur at the extremes of the input or output range and are used to verify that the system can handle unexpected inputs or outputs. For example, if the system is designed to handle a range of 1 to 10, an edge case test would be to check the system's behaviour when inputting 0 (the lower limit) or 11 (the upper limit).
__Corner Case:__ A corner case is a more severe version of an edge case, and it refers to a test case that tests the system's behaviour when multiple boundaries or limits are hit simultaneously. Corner cases are used to verify the system's behaviour when the input or output is at its maximum or minimum and the system's normal behaviour is altered. For example, if the system is designed to handle a range of 1 to 10, a corner case test would be to check the system's behaviour when inputting 0 and 11 at the same time.

__How do you test for side effects?__

__What kind of non-functional tests are you familiar with?__

__Have you been working with any CI/CD systems?__

Azure Devops, Betsson’s BeGo (sucked)

TeamCity, Jenkins

__What are the general steps of a CI pipeline?__

- Code Commit: Developers check-in their code changes into a version control system like Git, which triggers the CI pipeline.
- Build: The CI system retrieves the latest code changes and builds the code into an executable form.
- Test: The CI system runs automated tests to ensure that the code changes do not break existing functionality.
- Report: The CI system generates reports on the build and test results, making it easy to see which changes have been successful and which ones have failed.
- Deployment: If the build and test stages are successful, the CI system deploys the code changes to a staging environment for further testing and validation.
- Monitoring: The CI system continuously monitors the deployed code for any issues and provides notifications in case of failures or errors.
The goal of a CI pipeline is to catch and fix integration issues as early as possible in the development process, reducing the cost of fixing bugs later on and increasing the speed of delivering new features to customers. By automating the process, CI pipelines help to reduce the manual effort required to build and test code, freeing up developers to focus on other tasks.

__What is the difference between Continuous Integration/Deployment/Delivery?__

__Have you created a pipeline from scratch in the past?__

No. I Used Azure Devops and used Github Actions. 

__Can you tell us any gotchas that you have encountered?__

The servers that run your tests might have a different runtime than your development environment. This comes up when you are dealing with stuff that could be handled differently on different platforms. For example Linux deals with ISO country codes differently than windows. 
The `RegionInfo` class’s  properties return different values in case of windows/linux


__What kind of Non-Functional Requirements have you considered during your past assignments?__

A non-functional requirement is a requirement that specifies constraints or conditions on the system being developed, rather than specific behaviours. They describe how the system should perform, rather than what it should do. 
Some examples of non-functional requirements include:
Performance (e.g. response time, processing speed), 
Security (e.g. confidentiality, access control)
Scalability
Usability
Compatibility
Maintainability
Availability
These requirements help ensure that the system is delivered with the desired level of quality, reliability, and maintainability.

Which are the most important for you? Why?
For me maintainability is the most important because if it’s done right not only I will have an easier time maintaining the next person after me, this ensures to keep the technical debt to a minimum, this would have a snowball effect.

I see you have been working in a cloud environment. What kind of components have you used?
ResourceGroups, Subscriptions, Service Bus namespace(queues, topics, subscriptions), App service, SQL
What is IaaS, PaaS, SaaS and what is the difference between them?
IaaS (Infrastructure as a Service): 
IaaS provides customers with access to virtualized computing infrastructure, including servers, storage, and networking. Customers have complete control over the infrastructure and can use it to host and manage their own applications.
Example: Amazon Web Services (AWS), Microsoft Azure, Google Cloud Platform (GCP), DigitalOcean

PaaS (Platform as a Service)
PaaS provides a platform for developing, running and managing applications and services. It includes a pre-built environment for application development, deployment, and management, and often includes tools for load balancing, auto-scaling and monitoring.
Example: Heroku, Google App Engine, Microsoft Azure

SaaS (Software as a Service)
SaaS provides access to a fully-featured software application over the internet, without the need to install or manage any software or hardware. SaaS is delivered on a subscription basis and can be accessed from anywhere with an internet connection
Example: Salesforce, Google Apps, Microsoft Office 365, Dropbox, Slack

What more functionality a Service Bus provides us than a single Queue service?
A Service Bus provides more functionality compared to a single queue service by offering additional features and capabilities that can enhance the reliability and scalability of communication between systems. Some of the key differences between a Service Bus and a single queue service include:
Routing and filtering: Service Buses provide more advanced routing and filtering capabilities compared to a single queue service. This allows for more fine-grained control over message flow and processing.
Pub/Sub support: Service Buses support publish/subscribe messaging patterns, allowing for one-to-many communication between systems. A single queue service is limited to one-to-one communication.
Transactions: Service Buses provide transaction support for message processing, ensuring that all operations are completed as a single unit of work.
Batching: Service Buses allow for batching of messages, enabling systems to process multiple message


Do you have experience in Virtualization technologies?
Please describe as simply as you can, how does Docker work?
Docker is a platform that enables users to create, deploy, and run applications in containers. Containers are isolated environments that package an application and its dependencies together, allowing for consistent and efficient deployment across different environments. Docker provides a way to build, package, and distribute these containers, as well as manage their runtime behaviour. The Docker engine, which runs on a host operating system, provides the container runtime and manages the containers. This enables applications to run in a consistent and isolated environment, while leveraging the host's underlying resources. Docker images, which are snapshots of the containers, can be stored and distributed through a centralised registry, making it easier to share and reuse these environments.

Extra question: What are volumes?
In the Docker world, a volume is a way to persist data generated by and used by Docker containers. Volumes are defined as separate entities from the containers and they can be shared between multiple containers, allowing data to persist even if the original container is deleted or recreated. Volumes can be stored on the host file system or on a networked file system and they provide a mechanism for managing and backing up data used by Docker containers. Volumes are useful for storing data that should persist even if the container is removed, such as logs, configuration files, and data generated by applications.
Have you been working with any Container Orchestration Platforms?
I only know and tested Docker Compose and kubernetes.

Do you know what IaC is? Have you been working in such an environment?
Example: Terraform
Yes, IaC stands for Infrastructure as Code. It is a practice of using code to manage and provision infrastructure components and resources in a repeatable and automated way. The goal of IaC is to make the provisioning of infrastructure more efficient and less prone to errors than manual configuration and to allow for version control of infrastructure configurations.


Show us what you got!
We give the candidate an algorithm to implement. Usually asking the candidate to share screen on an online interview is a preferred way cause it
gives a personal comfort with the already known IDE. At this point the personality of the candidate is shown. Giving them the fake opportunity to
Choosing from task difficulty is an interesting measure. There are some cases the candidate chooses to test the interviewer with asking for the
most difficult task that is possible:
Implement an F-bounded quantification!
This task usually fails at the point of understanding, however it is an important task for this part of the interview.
Solution is to implement a Curiously Recurring Template Pattern (CRTP) in C#
Implementing such task from scratch should result in auto-hire, if the candidate can thoroughly explain the inheritance and workflow
details.
Some reasonable examples:
Implement Multiplication functionality without using the “*” sign!
Part of the requirement here is to understand we never say what other method the candidate chooses to utilise for the purpose, and haven’t
given any constraints.
Possible solutions: Math.Multiply(a,b), or if b==0 return 0 else return a/(1/b)
Few candidates give a list of test scenarios.
Usual approaches consist of an implementation of a cycle which will fail with some negative inputs.
Here the candidate usually copies the cycle and does not really think about the clean code patterns anymore.
Sometimes the candidate runs into complex if else statements which could be eventually shortened with the XOR operator in C#, which
is somehow not really known existing somehow.
In some cases the candidate tries to negate the result by: result = -1*result or result *= -1 in these cases a reminder is necessary about
the requirement to not use the “*“ sign. Attention can be dragged on the “-” unary operator, that a result = -result is acceptable.
Possible questions on the performance, with example inputs of a=2 b=3000000 vs a=3000000 b=2
Implement a method that returns ALL the Even Numbers
This usually confuses the candidate that this task is virtually impossible, here we need to drag his attention on the fact of .NET capabilities
of Deferred Execution and Enumeration.
Conversation should guide the candidate on the possibility for utilising the yield return statement.
It is advised to ask the candidate to trying out the code snippet created like with the AllEvens().Skip(3).Take(2).ToArray(); LINQ query
which should return an array with two elements: 6 and 8
Do you know…?
What is the difference between an Abstract class and an Interface?
Abstract class 
is a partially defined class that contains one or more abstract methods (i.e. methods without a body) and can contain both abstract and non-abstract methods. An abstract class is a blueprint for other classes and it can be extended to create concrete (i.e. non-abstract) classes.
An abstract method has no body, a virtual method has a body and can be overridden by child class. An abstract method is virtual.

Interface
on the other hand, is a pure abstract class with only abstract methods and no implementation. An interface defines a contract for classes to implement, providing a set of common methods that the implementing classes must implement. Unlike an abstract class, an interface cannot be instantiated and multiple inheritance is possible through the use of interfaces.

Differences
An abstract class can have both abstract and non-abstract methods, while an interface can only have abstract methods.
An abstract class can have instance variables and constructors, while an interface cannot.
An abstract class is used to define a blueprint for subclasses, while an interface is used to define a contract for classes to implement.
Multiple inheritance is possible with interfaces, but not with abstract classes.

Is there multiple inheritance in C#?
Nope

Can two interfaces have the same method signature?
Yes. 
How would you deal with the diamond problem -> Explicit implementation
https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/interfaces/explicit-interface-implementation

What is part of a method signature? / What’s not?
Return type, method name, method’s arguments. 
Not: the body/implementation of the method

How the situation changed with C# 8.0?
Is there any general principle set that you follow when constructing a class?
Yes, there are general principles that can be followed when constructing a class. These include the SOLID principles, which are a set of design principles for writing maintainable and scalable software. 

Additionally, classes should be designed to be easy to understand, maintain, and extend. This can be achieved by keeping the classes small and focused, minimising the use of global state, and keeping the dependencies between classes as loose as possible.

What does SOLID stand for?
The SOLID principles include:
Single Responsibility Principle (SRP): A class should have only one reason to change.
Open/Closed Principle (OCP): A class should be open for extension but closed for modification.
Liskov Substitution Principle (LSP): Subtypes should be replaceable by their base type.
Interface Segregation Principle (ISP): Clients should not be forced to depend on interfaces they don't use.
Dependency Inversion Principle (DIP): High-level modules should not depend on low-level modules, both should depend on abstractions.

Don’t you feel SRP and OCP are already contradicting each other?
What is covariance? How do you make a generic class covariant?
Can you give an example for contravariance?
What do you think, how can we connect the idea of “composition over inheritance” with interface segregation?
What is the connection between DIP, Inversion of Control and Dependency Injection?
What kind of DI frameworks have you been working with?
Have you met with GRASP before?
What is the main difference between a class and a struct?
What is every object derived from in C#?
What are the main methods we get with System.Object?
Why do we have to override the GetHashCode method alongside Equals?
If we know everything is derived from the System.Object, which is a Reference Type item, how can a struct be a Value Type then?
What part of the memory holds the data in C#?
What is responsible for cleaning the unused objects from the memory?
How does the GC work?
How many heaps are there?
What are the generations?
What is the size limit of an object to be allocated on the LOH instead of the SOH? / Why 85kB? / Are there exceptions?
How many stack frames a software creates during its runtime?
How would you implement a Finalizer?
When is it needed?
Why is IDisposable important in this context?
Why do you need to suppress the finalizer at an intentional call?
What is the true-false pattern?
Which Design Patterns have you used before?
It is a well known fact that the Singleton is an antipattern, why do you think it is?
How do DI frameworks have an impact on the commonly used patterns?
What kind of life cycles are you familiar with?
There is a task that takes a long time to run in your solution. How do you keep your software responsive?
What kind of asynchronous approaches are you familiar with?
What is the difference between System.Threading, the Task Parallel library and the async/await keywords?
What is the difference between Task.Run and Task.Factory.StartNew?
What does a compiler do with the async methods?
What is the MoveNext method?
What is the Synchronisation Context? What kind of pitfalls does it introduce?
You have been working with .NET more than (current year-2016) years. what is your experience when you had to switch between .NET
Framework to .NET Core?
How did Microsoft achieve cross platform functionality with .NET Core?
What are the differences between the Assembly loading?
How does the new Assembly load workflow prevent multiple package versions including?
From where do you load an Assembly in both versions of the framework?
According to what we talked about then, what kind of items do you find in the runtime library?
I see that you have been working with ASP.NET Core. What is the difference between UseMvc and AddMvc?
What is middleware? / Please give us some examples of usage!
Can you please describe the request pipeline for ASP.NET and the MVC endpoint?
In your CV it says you have been working with databases. How does an API connect to a database?
What kind of ORMs are you familiar with?
What is the difference between Database- and Code-First approaches?
How does Entity Framework create a query out of an IQueryable interface?
What does it decide whether a LINQ query turns into an Expression-Tree or an Anonym delegate?
What happens to a query if it has been run on an SQL database?
What is the difference between running a query several times or turning it into a Stored Procedure?
What is a Clustered/Nonclustered Index? What’s the difference?
What kind of Isolation Levels have you used in a Transaction? Can you describe them?

