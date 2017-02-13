# Sonneville.BeanCounter

A webapp to view and manage finances. Connects to Fidelity accounts through [FidelityWebDriver](https://github.com/SonnevilleJ/FidelityWebDriver).

## Developing
After cloning this repo, there are two things you must do before launching the app.

1. Update [Google API Credentials.json](https://github.com/SonnevilleJ/Sonneville.BeanCounter/blob/master/OwinWebApp/Google%20API%20Credentials.json) with your own Google API key.
1. [Per Microsoft](https://msdn.microsoft.com/en-us/library/ms733768(v=vs.110).aspx), if you're developing on Windows, you'll need to run the following command to allow non-administrator apps to provision the port when the app runs: `netsh http add urlacl url=http://+:80/ user=DOMAIN\user`
