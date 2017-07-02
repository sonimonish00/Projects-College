"""
Extract the email addresses from webpage using urllib2 module
"""
"""
References :- 

https://www.analyticsvidhya.com/blog/2015/10/beginner-guide-web-scraping-beautiful-soup-python/
http://www.pythonforbeginners.com/python-on-the-web/web-scraping-with-beautifulsoup/
http://scraping.pro/simple-email-crawler-python/

"""

from bs4 import BeautifulSoup
import requests,urllib.request,re

url = input("Enter a website to extract the Email Id from (www.example.com) : ")
finalurl = "http://" +url
response  = requests.get(finalurl)
data = response.text
soup = BeautifulSoup(data, "html.parser")
emails = set()

for link in soup.find_all('a'):
	link = link.attrs["href"] if "href" in link.attrs else ''
	#You Could add https also if required
	if not link.startswith('/') and not link.startswith('http'):
		link = finalurl+"/"+ link
		print(link)
		try:
			f = urllib.request.urlopen(link)
			s = f.read().decode('utf-8')
			list1 = re.findall(r"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",s,re.I)
			if not list1:
				pass
			else:
				emails.update(list1)
		except:
			pass
	else:
		continue

print("THE EMAILS FROM THE WEBSITE ARE ----------------------\n")
for i in emails:
	print(i)
