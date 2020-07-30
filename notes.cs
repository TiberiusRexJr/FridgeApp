/* 
cATEGORIES ( classes MOdelFridgeItem)
--fruits
--vegetables
--beverages
--condiment
--junk food
--

--FUNCTIONS
--IsExpiredAlert()
--nutrional infromation()
--buyer trend statstics()

--CONCEPTS
--database
--crud
--mvc
 */

 /*
 ONSTARTUP
 check DATA-PERSISTANCE OBJECT if SETTINGS_OBJ.KEPPT_ME_LOGGED_IN==true
    1. call SECURE_STORAGE OBJ to see if TOKEN EXIST

if DATA-PERSISTANCE OBJECT, SETTINGS_OBJ.KEPT_ME_LOGGED_IN==false
    2. APP.MAINPAGE=LoginPage
    //when does session token expire//
 
 */

 /*
    OBJECT_PERSISTENCE(settings) vs SECURE_STORAGE(keep_me_logged in, registered?, db_access) vs SESSION_TOKEN (registered?, db_access, functionality even if "keep_me_logged in"=false)
    1. Want to store settings (just a simple settings page)
    2. Want to store credentials (encryption)==> see "B"
    3. 2 different things
    4. HOW TO USE
        A. ON STARTUP
            a. load up SETTINGS_OBJ see if "keep_me_logged in" is TRUE==>see "B"
            b. if yes look for a SECURE_STORAGE OBJECT LOAD CREDENTIALS
            c. if objeect is not found AND OR "auto-login" is FLASE
            d. => send to LOGIN_PAGE
        B. WHEN TOGGLE IS SWITCHED TO 
            1. false
                a. look for a CREDIENTAILS_OBJ in a USER_FOLDER and delete it, keep SESSION_TOKEN
            2. true
                a. navigate to USER_FOLDER, look for CREDENTIALS_OBJ
                b. IF CREDNETIALS_OBJ exist, return. else create CREDENTIALS_OBJ from USER_PASSWORD AND USER_EMAIL from SESSION_TOKEN
        C. SESSION_TOKEN
            1. created upon login from USER_PASSWORD & USER_EMAIL
            2. SESSION_TOKEN is maintained until "logout" is clicked

    5. what i don't know
        A. 
 */

 /* 
 DATABASE
    1. ON_STARTUP
        A. DATABASE_obj existense check

  */

  /* ASYNC
        1. Eventually make Async for REGISTER_BUTTON things like that
   */

  ON_STARTUP()
  {
      DATABASE_SINGELTON

  }