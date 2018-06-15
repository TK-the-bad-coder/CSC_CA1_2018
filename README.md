Task 1
Things to note - Data Annotation, know how to explain if he asks you . Example range 0,100, what does it mean
Screenshots to have: Trigger all possible use case / alternate use case for GET/POST/PUT/DELETE, ModelState invalid, underposting, overposting etc.

——

Task 2
OAuth method - Found in App_Start/Startup.Auth.cs [To disable AllowInsecureHttp]

Set Project to Enable SSL, can be found under Properties > Development Server 

Under Project Properties, ensure SSL is enabled by double clicking on it, else the project will not load any webpage to you.
Access the project via SSL URL which is also found right under the SSL Enabled option.
Step to take : Debug/Run Project (Task 2), it will throw you error. Change the URL and navigate to the SSL URL, allow Exception.

Do a failed request, successful request. Take screenshots for both. You should do via Postman as well, which can be slightly tricky to execute. 
Make sure you know how to play with the Postman app (For Post man, you need to test with the normal URL to get the error message screenshot too)

Study the diagram found in the webpage, just focus on a few things like: key in correct password, server returns token to client, client give token to resource server, server gives back resource, and then there is filter features.. etc etc.

If he ask where is the javascript logic residing, its in app.js, a javascript file that you have created for the project.

Screenshots to have:
Postman - Normal URL, try to retrieve the page, you should get error messages.
SSL URL, try to register and login, retrieve the token. (show him how you get the token during interview, this should be set in the headers by adding a authorization key field)
Front-End page results for Failed Login, Illegal Request of data.

——

Task 3
Follow through the practical
Things to note:
Install CORS via NuGet. WebApi.Cors
Create RequireHttpsAttribute.cs for the solution.
Make sure the TalentsController is using the right things

Screenshots - Simple Post Man CRUD functions via TalentsController.

Optional Feature (which is a mock product of Task 4) - Search Talent (no api involved)

——

Task 4
This is literally Task 3 Optional Feature, with real API controllers doing CRUD, and the securing part is to make use of Task 1 and Task 2 (Data Annotation and SSL)

Screenshots to take: Unsecure access of Talent API via Postman, error error error. Authorized/HTTPS/SSL access of Talent API via Postman and front end page.

Perform CRUD via Postman and front-end client (need to ownself make, not provided by assignment).

REPEAT: CODE NOT PROVIDED FOR THIS TASK AS THIS IS COMBINING STEPS FROM PREVIOUS TASKS AND CREATING SOME NEW VIEW PAGES.

Pages to make - CRUD pages.

——

Task 5
STRIPE - The NuGet package is new, and the code that JiPX provided is not usable with the new STRIPE package. Take note of the updated codes found in the backend.

Screenshots to take: Success page at Stripe etc, front-end page. Postman optional.

AWS S3 - Just make sure your code works..the javascript code provided confirm works. Just that the UI cui only. Doesn't matter.

Screenshots to take: Image upload successfully and able to retrieve the image data / image back out. To show your S3 bucket.

————

There are SOME youtube videos to watch, that could help you better understand what are the missing details or hidden steps to take for the tasks above. Task 4 is relatively tricky.

Suggested Youtube Vids: RequireHttpsAttribute (https://www.youtube.com/watch?v=xIzlD-frEw4&t=179s), Authentication (https://www.youtube.com/watch?v=BZnmhyZzKgs)