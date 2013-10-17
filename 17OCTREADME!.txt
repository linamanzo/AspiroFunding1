I'm trying to test the personnal details as follow :

the button "get infos" on the Form1 interface calls a two methods (GetStatusbyId and GetResStatus) (tests) in the user manager
already declared in the load of the form, which is calling an instance f the personnal manager that connects to the Database.

Then the user manager calls a method for each method in the personnal details manager (GetMAritalStatus for GetStatusbyId, and GetResStatus for Resstatus)
 
Those last methode are actually supposed to bring back whatever is in the attributes of the class Personnal Details.
In order to bring them back i have to create an instance of the Personnal details Object.
(which is called apersD in the P.D Manager) But then it goes to the personnal details class and i must put a builder there, but i 
have no clue about what to put inside really.

The problem is that i need to create an instance of it, otherwise V.S says that there is no reference to the object.
But then obviously it goes to this builder that's empty.

So, i'm basically stuck there.
I'll try to find a way but i have to admit i'm kind of lost right now.

Really sorry abut the delays.