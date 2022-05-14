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
