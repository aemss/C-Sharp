
using LinkedList;

var browser = new BrowserHistory();

browser.VisitPage("Google.com");
browser.VisitPage("btkakademi.gov.tr");
browser.VisitPage("samsun.edu.tr");

browser.Back();
browser.Back();
browser.Forward();

browser.ShowHistory();

