# selenium-tests-skeleton

## Introduction
This is a skeleton to remember how to run Selenium UI tests in dotnet core 2.x using C#. 

## Run the Selenium Standalone Chrome in Docker locally
```
docker run -d -p 4444:4444 -v /dev/shm:/dev/shm selenium/standalone-chrome
```

## Usage of Selenium WebDriver
In GoogleTests.cs you can point to Chrome Options, start a Remote Driver to use the stand-alone (or even Selenium Hub really) and then get going. If you do not use the Remote one, it opens locally interactively which in a true CI/CD you do not want!