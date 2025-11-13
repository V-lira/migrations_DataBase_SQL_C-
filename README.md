# migrations_DataBase_SQL_C-
task:
1.	Create entities in the Model.cs file:
Doctor (id, fullname, salary, departmentId, navigation property for department association)
 <img width="706" height="351" alt="image" src="https://github.com/user-attachments/assets/6a93c89a-96d6-4fc1-8c80-0d732ff51a2f" />

Department (id, departmentName, navigation property for doctor association)
 <img width="705" height="230" alt="image" src="https://github.com/user-attachments/assets/e72f978e-2d9f-4670-ac44-e2f10a7fb5de" />

2.	Create the Context.cs file:
Implement DbSet for each table representation

 <img width="876" height="169" alt="image" src="https://github.com/user-attachments/assets/ead87b08-9550-45d6-ae44-5376c815e15a" />

Implement the OnConfiguring method for the connection string
 
<img width="974" height="186" alt="image" src="https://github.com/user-attachments/assets/e24a8da2-6e6c-4a24-b690-ca1e8fb5cd49" />


Implementation process:

To create the necessary file, I did it as follows:
Used PowerShell and commands in it
 <img width="1008" height="28" alt="image" src="https://github.com/user-attachments/assets/9f276e97-1ffe-4475-978c-6b27a2a64bdd" />
 <img width="1012" height="38" alt="image" src="https://github.com/user-attachments/assets/75664403-85d0-4620-8c37-e3f6cd12c61e" />

 

Downloaded required packages via NuGet packages in the project. Version – 9.0.11
 <img width="974" height="272" alt="image" src="https://github.com/user-attachments/assets/f018c992-249c-450b-95e3-4691495f6ec2" />

Added code to insert content into tables
 <img width="974" height="268" alt="image" src="https://github.com/user-attachments/assets/f6691cd1-93a6-4dc9-b06b-5bd2c23b284e" />


Added this line of code to verify that everything worked (data was added)
 <img width="915" height="81" alt="image" src="https://github.com/user-attachments/assets/2f3e9431-8331-44b7-b620-9c10339d957a" />






Database migration and update:
After writing the code, I create a migration and update the database through the Project Manager Console:
Add migration:
 <img width="511" height="117" alt="image" src="https://github.com/user-attachments/assets/6c529133-469a-4d3f-af71-7523c92bab6d" />

Update database:
 <img width="974" height="95" alt="image" src="https://github.com/user-attachments/assets/94ba4238-dc3a-47c5-86e2-7f1ceb6c98ef" />






Note: This will only execute if the departments table is empty. 
 <img width="974" height="361" alt="image" src="https://github.com/user-attachments/assets/fc74b43d-42e9-4e60-a568-3e39d68b8199" />

Final result:
 <img width="590" height="206" alt="image" src="https://github.com/user-attachments/assets/c0eea162-61ad-49f6-b7d1-c9657e9e62e9" />



In Microsoft SQL Server, the tables now look like this (+migrations):
 <img width="997" height="254" alt="image" src="https://github.com/user-attachments/assets/bcf27d8f-951b-4fdb-8e0e-5d14d751b3bf" />

Migration table:
 <img width="604" height="216" alt="image" src="https://github.com/user-attachments/assets/4e75d3ac-fff3-4727-8fa9-24a9b209ddc7" />


Actual tables with content
 <img width="992" height="398" alt="image" src="https://github.com/user-attachments/assets/520a76c0-b959-46cc-8728-00c487219ee0" />

Output:
 <img width="992" height="225" alt="image" src="https://github.com/user-attachments/assets/125e8061-d8a2-4ceb-bf29-070eff10e4a0" />

