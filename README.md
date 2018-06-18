# ST0280: Cloud and Service Computing Assignment (CA1)
Pardon my bad English. If you need further assistance, or found some bugs / errors that is not covered here, or need help to go through the assignment together, please contact me on Telegram!

Task 4 is not provided here as of 17 June 2018, you can modify Task 3 or duplicate Task 3 to work on your Task 4.

## How to setup the project (If the packages are not installed)
* After unzipping the folder (if you have downloaded it) or cloned the project, open `CSCAssignment2018.sln`.
    * Do not open individual solutions' `*.csproj`, the projects wont be able to run.
* Ensure you have ASP .NET 4 and above framework installed.
* Check through the projects. If any project have error, please install the relevant packages for each project.
Packages Needed: (All Via NuGet)
```
 $ CORS - Microsoft.AspNet.WebApi.Cors [Task 1 and Task 3 needs it]
 $ Stripe - Stripe.net [Task 5]
```

* Right click on Task 1 (In this repo, its CSCAssignment2018) and select `Manage NuGet Packages...` and navigate to `Browse`, and search for `WebApi.Cors`. Install the package and accept the defaults. Repeat this for Task 3

* Right click on Task 5, and select `Manage NuGet Packages...` and navigate to `Browse`, and search for `Stripe.net`. Install the package and accept the defaults.

Run the following commands on the Package Manager Console that is built in within Visual Studio (Requires 2012 or later, not available on Mac) if you prefer to use commands instead of the GUI
```
$ Install-Package Microsoft.AspNet.WebApi.Cors # Make sure the 'Default Project' is selected on Task 1, and repeat this for Task 3
$ Install-Package Stripe.net # Make sure the 'Default Project' is Task 5
```

## How to run the projects individually
Right click on the project that you want to test / run via `Solution Explorer`, and you have two choices:

1. Select **Set as Startup Project**, and start the project as per normal
2. Hover over **Debug**, and select **Start new instance**

Example usage when I want to start Task 3:
* Right-click on Task 3, hover over **Debug**, and select **Start new instance**.


## Task 1
Things to note - Data Annotation, know how to explain if he asks you . Example range 0,100, what does it mean
Screenshots to take: Trigger all possible use case / alternate use case for `GET/POST/PUT/DELETE`, `ModelState` invalid, **underposting**, **overposting** etc. 

If you do not know what is **underposting** or **overposting**, please consult your classmates... As of now, the codes does not handle overposting. But just explain to JiPX if he asks you to do a overpost, that the request will still pass through. However no requests should pass through (Eg. creating a new product) if the request underposted. (The `Required` field handles this)

Interview:
There are THREE `ProductsControllers` within this project, differentiated by `ProductsV1Controller`,`ProductsV2Controller`, `ProductsV3Controller`
`V3` is the combination of `V1` and `V2`, refer to `V3` for the full version. However, some error messages only can be showed by `V1` or `V2`, as `V3` contains codes that handles the error. If JiPX asks you to show him comparison or show error messages, `V1` and `V2` will be your solution.

## Task 2
OAuth method - Found in `App_Start/Startup.Auth.cs` [To disable AllowInsecureHttp]

Set Project to **Enable SSL**, can be found under `Properties > Development Server `

Under Project Properties, ensure SSL is enabled by double clicking on it, else the project will not load any webpage upon starting.
Access the project via SSL URL which is also found right under the SSL Enabled option.
Step to take : Debug/Run Project (Task 2), it will throw you error. While project is running, change the URL and navigate to the SSL URL, allow the security exception, if any.

If he asks you how to prevent the security exception, or if you want to do it, you may refer to this webpage on [Enable SSL on Visual Studio](http://csharp-video-tutorials.blogspot.com/2016/09/enable-ssl-in-visual-studio-development.html), which also teaches you how to create your own security certificate.

Do a failed request, successful request. Take screenshots for both. You should do via Postman as well, which can be slightly tricky to execute. 
Make sure you know how to play with the Postman app (For Postman, you need to test with the normal URL to get the error message screenshot too)

Study the diagram found in the webpage, just focus on a few things like: key in correct password, server returns `token` to client, client give `token` to resource server, server gives back resource, and then there is filter features.. etc etc.

If he ask where is the javascript logic residing, its in `app.js`, a javascript file that you have created for the project.

Screenshots to take:
Postman - Normal URL, try to retrieve the page, you should get error messages.
SSL URL, try to register and login, retrieve the token. (show him how you get the `token` during interview, this should be set in the headers by adding a authorization key field)
Front-End page results for failed login, Illegal Request of data.

## Task 3
Follow through the practical
Things to note:
Install `CORS` via NuGet. Package Name End with `WebApi.Cors`
Create a class file `RequireHttpsAttribute.cs`,put it at the root folder of Task 3.
Make sure the TalentsController is using the right things

Screenshots to take: Simple Post Man CRUD functions via TalentsController.

Optional Feature (which is a mock product of Task 4) - Search Talent (no api involved)



## Task 4
This is literally Task 3 Optional Feature, with real API controllers doing CRUD, and the securing part is to make use of Task 1 and Task 2 (Data Annotation and SSL)

You may want to provide Create/Update/Delete Talent API View Pages, therefore you also may want to create the respective `Views Controller` for Talent.
Remember that this task he may ask you to demonstrate whether you can do CRUD here, so doing this portion may just be a safeguard, it may not be neccessary to do.

Screenshots to take: Unsecure access of Talent API via Postman, error error error. Authorized/HTTPS/SSL access of Talent API via Postman and front end page.

Perform CRUD via Postman and front-end client (*need to ownself make, not provided by assignment*).

**REPEAT: CODE NOT PROVIDED FOR THIS TASK AS THIS IS COMBINING STEPS FROM PREVIOUS TASKS AND CREATING SOME NEW VIEW PAGES.**

I will provide the CRUD pages at a later time, but do not depend on me to do it for you as I may not be able to do it before your deadline!

Things to do:
1. Data Annotations on `Talent` Model
2. `ModelState.IsValid()` on Controller
3. `Enable SSL` (With all the steps that you have taken to Enable SSL)
4. `RequireHttps` (Code has been provided in Task 2 as well, but if you want to know how to explain better, follow this [Enable HTTPS](http://csharp-video-tutorials.blogspot.com/2016/09/aspnet-web-api-enable-https.html) )

Advanced Features [Or basically spoil the market section]:
This portion below requires you to refer to the websites that is found inside the youtube video's description
It is good to do them if you have time to do so, as it would make it more complete. However, not doing them does not result you in loss of marks, but whoever has done it may set a benchmark of how to get full marks for Task 4.
1. Provide a login functionality for Authentication. 
    - This would serve as a purpose that user must log in first, before they can see the Talents.
    - Follow this tutorial - [Implementing Basic Authentication](http://csharp-video-tutorials.blogspot.com/2016/10/implementing-basic-authentication-in.html)
    - You also can take a step up further by implementing Google Login. Somewhere along his practical notes/slides provides this functionality.
2. Store the data in a local DB within Microsoft Visual Studio instead of using Talent Repository
    - So that whenever the project runs, you can update / delete talents accordingly, and can still see the same result when you restart the project.
    - This also allows different users (if you have done Authentication) to see the same data too.
3. Ensure the error codes are returned correctly. Eg. `401 Unauthorized` etc. 

## Task 5
`STRIPE` - The NuGet package is new, and the code that JiPX provided is not usable with the new `STRIPE` package. Take note of the updated codes found in the backend.

Please put your secret test key in by replacing the `"test_key"` inside the StripeController
`var chargeService = new StripeChargeService("test_key");`

Screenshots to take: Success page at Stripe etc, front-end page. Postman optional.

`AWS S3 Bucket` - ~~Just make sure your code works..the JavaScript code provided by JiPX confirm works. Just that the UI cui only. Doesn't matter. Make your own if you need to. Remember to provide the relevant credentials. Follow the AWS S3 Bucket Tutorial closely. You can change your `region` accordingly if you selected your own instead of following the practical.~~

~~Screenshots to take: Image upload successfully and able to retrieve the image data / image back out.~~

UPDATE: The crossed out region is for CA2, as confirmed by JiPX. AWS S3 Bucket is just for you to dump talent photos inside. However, you can still provide a webpage for you to demonstrate how you dump the talent photos inside via your own project.

Interview: Prepare to show Stripe Page, AWS S3 Bucket **\(With talent photos inside)**

### Additional Notes / Other Important Things to take note of

There are SOME youtube videos to watch, that could help you better understand what are the missing details or hidden steps to take for the tasks above. Task 4 is relatively tricky.

UPDATE as of 18 June: I have provided links onto the tasks above that contains the video and the document version of the video, I will put it below again to serve as a reminder that you can refer to them and aid you in explaining to JiPX during the interview!

Please be reminded that the project **DOES NOT include** the *loading gif* or a *retry feature* when any of the CRUD feature is loading / failed to load via AJAX on the front end client. Try to implement this on either Task 5 or Task 4 (Talents API View Pages, which is also not provided in this project)


Suggested Youtube Videos: [RequireHttpsAttribute](https://www.youtube.com/watch?v=xIzlD-frEw4&t=179s), [Authentication](https://www.youtube.com/watch?v=BZnmhyZzKgs)

Useful tutorial links that may help you to understand better how the code works / project flows, improving how you can explain yourself during 
interview:
* [Implement Basic Authentication & ADO.NET Entity Model](http://csharp-video-tutorials.blogspot.com/2016/10/implementing-basic-authentication-in.html)
* [Enable Https](http://csharp-video-tutorials.blogspot.com/2016/09/aspnet-web-api-enable-https.html)
* [Enable SSL](http://csharp-video-tutorials.blogspot.com/2016/09/enable-ssl-in-visual-studio-development.html)