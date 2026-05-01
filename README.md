Introduction 

This project is the second phase of the SomaShare platform, developed as part of a continuous assessment. In the first phase (SS1), the booksXrelays team focused on research, planning, and system design. This included identifying key features, defining system requirements, and ensuring the application would function logically and effectively. 
In this phase (SS2), the focus is on implementing the system as a fully functional web application. SomaShare is a web-based platform developed using ASP.NET Core MVC. The system allows university students to buy, sell, and exchange textbooks within a trusted campus community.  
The application includes features such as user authentication, role-based access (Buyer, Seller, Admin), textbook listings, wanted ads, offers, transactions, reviews, and a user dashboard. These features aim to promote affordability, accessibility, and community trust among students. 

 

Technologies 

ASP.NET Core MVC was used as the main framework to build the SomaShare web application. This is because it follows the Model-View-Controller architecture, which helps separate the application into different parts (models, views, and controllers). This enhances the system and makes it easier to organize, maintain, and scale. 
C# was used as the programming language for developing the application logic. This is because it integrates well with ASP.NET Core and promotes strong typing, object-oriented programming, and efficient handling of data and business logic. 
SQL Server Express was used as the database to store all application data of SomaShare. This includes users, textbooks, offers, transactions, and reviews. That said, it provides a reliable and structured way to manage data using relational tables. 
Entity Framework Core was used as the data access technology. The Code-First approach allows the database to be created directly from C# models, making development faster and ensuring consistency between the application and the database. 
Bootstrap was used for the user interface design, as it provides pre-built styles and components that make the application responsive and visually appealing without needing complex custom CSS. 
GitHub was used for version control and project management. This is because it encourages tracking of changes, collaboration, and maintaining a history of the development process through commits. 

 

 


System Features of SomaShare 

User registration and login with roles (Buyer, Seller, Admin) 
Textbook listings (Create, Edit, Delete) 
 Wanted Ads (Create, Edit, Delete) 
Offers system (make, accept, reject) 
Transactions (created after accepting offer) 
 Reviews and ratings 
Logical Dashboard for user activity 
Search and filtering of textbooks (title, module, author) 
Database and Data Architecture 

ERD Diagram: 
<img width="814" height="753" alt="image" src="https://github.com/user-attachments/assets/d7f7c1e0-79f7-49f8-b509-a863966ec051" />



Database Table Details: 

The SomaShare database consists of several related tables. The AspNetUsers table stores user information such as student number, name, campus and email. 
The Textbook table stores book listings created by sellers. Each textbook is linked to a user through SellerId. 
The WantedAd table allows buyers to request textbooks. 
The Offer table stores offers made by potential buyers on textbooks. 
The Transaction table is created when an offer is accepted and tracks completion. 
The Review table allows users to rate transactions. 
The Category and TextbookCategory tables implement a many-to-many relationship. 

 

 

Database Relationships: 

One user can create many textbooks 
One user can create many wanted ads 
One user can make many offers 
One textbook can have many offers 
One offer creates one transaction 
One transaction has one review 
Many-to-many between textbooks and categories 

 

Africanisation features 

Cash on Meetup Payment Option 
The Cash on Meetup feature allows students to complete transactions in person on campus. This feature is key because it increases safety and trust, as users can verify the textbook before completing the purchase. 
 
Language Toggle (English / isiZulu) 
The language toggle improves accessibility by allowing users to switch between like English and isiZulu. This supports inclusivity and ensures that the application can be used by a wider range of students who may be more comfortable in different languages. 

Community Trust Through Reviews and Ratings 
The review and rating system plays a pivotal role in building trust among users. Students can rate their experiences after transactions, which allows others to make informed decisions. This encourages honesty and accountability within the platform. 

Affordable Access to Learning Materials 
The main goal of SomaShare is to make textbooks more affordable. By allowing students to buy and sell second-hand books, the system reduces costs and makes educational resources more accessible, which is especially important in many African higher education environments. 

 

Screenshots 

Database Tables 
<img width="592" height="496" alt="image (1)" src="https://github.com/user-attachments/assets/9f5f5314-9978-4035-86cf-352b870343f4" />

Register Page
<img width="802" height="647" alt="image (2)" src="https://github.com/user-attachments/assets/bb6853b3-6254-4b33-9fab-ea216b0e90a0" />

Login Page 
<img width="745" height="421" alt="image (3)" src="https://github.com/user-attachments/assets/fe3d5950-e39d-4a36-a723-b885fa5c8a3a" />
 
Dashboard 
<img width="940" height="533" alt="image (4)" src="https://github.com/user-attachments/assets/df6f5ec5-1de7-4b66-9f84-c3bf8bc74131" />

Textbooks Page 
<img width="940" height="393" alt="image (5)" src="https://github.com/user-attachments/assets/8bb80a02-4bbf-452f-baff-49f995379262" />
 
Offers Page
<img width="751" height="374" alt="image (6)" src="https://github.com/user-attachments/assets/0d873935-a960-4da8-a535-231a7b67859c" />


WantedAd Page 
<img width="702" height="394" alt="image (7)" src="https://github.com/user-attachments/assets/27cfd00a-6b12-46e8-8b78-6581f9370165" />

Transactions Page
<img width="940" height="522" alt="image (8)" src="https://github.com/user-attachments/assets/30d9e29f-5d11-4f3c-9d71-4bbc34f6bb12" />

Reviews Page  
<img width="940" height="522" alt="image (8)" src="https://github.com/user-attachments/assets/a6837f7f-460e-4923-900a-7ef0faf6e23c" />


Conclusion 

In conclusion, the SomaShare web application efficiently demonstrates the development of a data-driven system using ASP.NET Core MVC. The project meets all the key requirements such as user authentication, role-based access, CRUD operations, and a structured relational database. 
Furthermore, through this project, important concepts such as the MVC architecture, Entity Framework Core, and database relationships were applied to create a functional and user-friendly system. Features such as textbook listings, offers, transactions, reviews, and the dashboard work together to provide a complete user experience. 
In addition, the system incorporates Africanisation features such as cash on meetup, language support, and community trust through reviews, making it relevant to the local context. 
Therefore, the project demonstrates both technical understanding and practical application, resulting in a platform that supports affordable access to learning materials for students. 



