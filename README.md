# ProductAppOnionArchitecture
## Onion Architecture with Mediatr
</br>
The Onion architecture, introduced by Jeffrey Palermo, offers to solve the problems that the N-tier layered architecture will experience in the future. The game-changing thing with Onion is that the Domain Layer (the onion's twig so to speak) Entities are at the Center of the Whole Application. This means higher flexibility and fewer connections. In this approach, we can see that all Tiers depend only on Core Tiers.
</br>
<img src="https://miro.medium.com/max/924/1*0Pg6_UsaKiiEqUV3kf2HXg.png"/>
</br>
<h3> Domain </h3>
The domain, that is, the property layer, contains the entities to be used in the whole structure. (eg Products, Categories, Shippers etc..) we should be able to access this layer from within a core layer. In the kernel, we see that there is the Application layer.

### Application
 In the application layer, there are contracts for transactions such as querying, adding, deleting the entities in the Domain layer (Interface).

### Infrastructor
 It is used as the infrastructure layer. In this layer, there are objects such as Database objects, dependency injection.

### Persistence
 We see that it is a part of the infrastructure layer. It communicates with the infrastructure layer to which it is connected by creating a DbContext (Database object) in the Persistance layer.

### Presentation
 This area, which is the presentation layer, contains the platform on which the project will be presented. For example Web, Api, Console etc…

## CQRS 
As you know, requests from the user on an application are of two types. The incoming request either manipulates/modifies existing data or creates a nonexistent data, or allows it to be read directly without any action on the existing data. So long story short, the incoming request either does a read-only operation or does other operations. The requests that will perform the read operation from these operations are called Query, and the others are called Command.

### Command
These are requests that create non-existent data or update or delete existing data.
</br>


INSERT UPDATE DELETE
### Query
These are requests that perform a read operation just to list, read, or present the available data.
</br>
SELECT

## Mediatr
Mediator is a design pattern that allows you to manage the complex web of relationships between various objects within a single mediator object.
