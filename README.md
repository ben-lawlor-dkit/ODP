# ODP

Welcome to my Observer & Decorator pattern demo.
---
Enter your email address and password at:

CustomerDetails.cs  
    `public void SendEmail(string email)`  
    * var senderEmail,  
    * var password,  
    and in the body of  
    * var mess = new MailMessage(senderEmail, receiverEmail)  
           
and in
  
Subjects\Customer.cs  
    `public void Update(ISubject subject)`  
    var senderEmail,  
    var password,  
    and in the body of  
    var mess = new MailMessage(senderEmail, receiverEmail)  

