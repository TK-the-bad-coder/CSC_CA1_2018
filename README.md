# ST0280: Cloud and Service Computing Assignment (CA1)


## Task 1
Things to note - Data Annotation, know how to explain if he asks you . Example range 0,100, what does it mean
Screenshots to have: Trigger all possible use case / alternate use case for `GET/POST/PUT/DELETE`, `ModelState` invalid, **underposting**, **overposting** etc.

## Task 2
OAuth method - Found in `App_Start/Startup.Auth.cs` [To disable AllowInsecureHttp]

Set Project to **Enable SSL**, can be found under `Properties > Development Server `

Under Project Properties, ensure SSL is enabled by double clicking on it, else the project will not load any webpage upon starting.
Access the project via SSL URL which is also found right under the SSL Enabled option.
Step to take : Debug/Run Project (Task 2), it will throw you error. While project is running, change the URL and navigate to the SSL URL, allow the security exception, if any.

If he asks you how to prevent the security exception, or if you want to do it, you may refer to the webpage that teaches you how to setup SSL (not the Microsoft/Azure Page) tutorial, which teaches you how to create your own security certificate.

Do a failed request, successful request. Take screenshots for both. You should do via Postman as well, which can be slightly tricky to execute. 
Make sure you know how to play with the Postman app (For Post man, you need to test with the normal URL to get the error message screenshot too)

Study the diagram found in the webpage, just focus on a few things like: key in correct password, server returns token to client, client give token to resource server, server gives back resource, and then there is filter features.. etc etc.

If he ask where is the javascript logic residing, its in `app.js`, a javascript file that you have created for the project.

Screenshots to have:
Postman - Normal URL, try to retrieve the page, you should get error messages.
SSL URL, try to register and login, retrieve the token. (show him how you get the `token` during interview, this should be set in the headers by adding a authorization key field)
Front-End page results for Failed Login, Illegal Request of data.

## Task 3
Follow through the practical
Things to note:
Install `CORS` via NuGet. Package Name End with `WebApi.Cors`
Create a class file `RequireHttpsAttribute.cs`,put it at the root folder of Task 3.
Make sure the TalentsController is using the right things

Screenshots - Simple Post Man CRUD functions via TalentsController.

Optional Feature (which is a mock product of Task 4) - Search Talent (no api involved)



## Task 4
This is literally Task 3 Optional Feature, with real API controllers doing CRUD, and the securing part is to make use of Task 1 and Task 2 (Data Annotation and SSL)

You may want to provide Create/Update/Delete Talent API View Pages, therefore you also may want to create the respective `Views Controller` for Talent.
Remember that this task he may ask you to demonstrate whether you can do CRUD here, so doing this portion may just be a safeguard, it may not be neccessary to do.

Screenshots to take: Unsecure access of Talent API via Postman, error error error. Authorized/HTTPS/SSL access of Talent API via Postman and front end page.

Perform CRUD via Postman and front-end client (*need to ownself make, not provided by assignment*).

**REPEAT: CODE NOT PROVIDED FOR THIS TASK AS THIS IS COMBINING STEPS FROM PREVIOUS TASKS AND CREATING SOME NEW VIEW PAGES.**

I will provide the CRUD pages at a later time, but do not depend on me to do it for you as I may not be able to do it before your deadline!



## Task 5
`STRIPE` - The NuGet package is new, and the code that JiPX provided is not usable with the new `STRIPE` package. Take note of the updated codes found in the backend.

Please put your secret test key in by replacing the `"test_key"` inside the StripeController
`var chargeService = new StripeChargeService("test_key");`

Screenshots to take: Success page at Stripe etc, front-end page. Postman optional.

`AWS S3 Bucket` - Just make sure your code works..the JavaScript code provided by JiPX confirm works. Just that the UI cui only. Doesn't matter. Make your own if you need to. Remember to provide the relevant credentials. Follow the AWS S3 Bucket Tutorial closely. You can change your `region` accordingly if you selected your own instead of following the practical.

Screenshots to take: Image upload successfully and able to retrieve the image data / image back out.

Interview: Prepare to show Stripe Page, AWS S3 Bucket

### Additional Notes / Other Important Things to take note of.

There are SOME youtube videos to watch, that could help you better understand what are the missing details or hidden steps to take for the tasks above. Task 4 is relatively tricky.

Please be reminded that the project **DOES NOT include** the *loading gif* or a *retry feature* when any of the CRUD feature is loading / failed to load on the front end client. Try to implement this on either Task 5 or Task 4 (Talents API View Pages, which is also not provided in this project)


Suggested Youtube Videos: [RequireHttpsAttribute](https://www.youtube.com/watch?v=xIzlD-frEw4&t=179s), [Authentication](https://www.youtube.com/watch?v=BZnmhyZzKgs)