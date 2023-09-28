"""Following Links in Python

In this assignment you will write a Python program that expands on http://www.py4e.com/code3/urllinks.py. The program will use urllib to read the HTML from the data files below, extract the href= vaues from the anchor tags, scan for a tag that is in a particular position relative to the first name in the list, follow that link and repeat the process a number of times and report the last name you find.

We provide two files for this assignment. One is a sample file where we give you the name for your testing and the other is the actual data you need to process for the assignment

Sample problem: Start at http://py4e-data.dr-chuck.net/known_by_Fikret.html
Find the link at position 3 (the first name is 1). Follow that link. Repeat this process 4 times. The answer is the last name that you retrieve.
Sequence of names: Fikret Montgomery Mhairade Butchi Anayah
Last name in sequence: Anayah
Actual problem: Start at: http://py4e-data.dr-chuck.net/known_by_Possum.html
Find the link at position 18 (the first name is 1). Follow that link. Repeat this process 7 times. The answer is the last name that you retrieve.
Hint: The first character of the name of the last page that you will load is: H"""


# Enter URL: http://py4e-data.dr-chuck.net/known_by_Possum.html
# Enter count: 7
# Enter position: 18
"""
Retrieving:  http://py4e-data.dr-chuck.net/known_by_Possum.html
Retrieving:  http://py4e-data.dr-chuck.net/known_by_Ireoluwa.html
Retrieving:  http://py4e-data.dr-chuck.net/known_by_Eli.html
Retrieving:  http://py4e-data.dr-chuck.net/known_by_Natane.html
Retrieving:  http://py4e-data.dr-chuck.net/known_by_Rianna.html
Retrieving:  http://py4e-data.dr-chuck.net/known_by_Jaden.html
Retrieving:  http://py4e-data.dr-chuck.net/known_by_Tyla.html
Last Name:  Harish
"""
#Name: Harish
from bs4 import BeautifulSoup
import urllib.request as ur

current_repeat_count = 0
url = "http://py4e-data.dr-chuck.net/known_by_Possum.html"
repeat_count = 7
position = 18

def parse_html(url):
    html = ur.urlopen(url).read()
    soup = BeautifulSoup(html, 'html.parser')
    tags = soup('a')
    return tags

while current_repeat_count < repeat_count:
    print('Retrieving: ', url)
    tags = parse_html(url)
    for index, item in enumerate(tags):
        if index == position-1:
            url = item.get('href', None)
            break
        else:
            continue
    current_repeat_count += 1

# После завершения цикла while, url содержит URL последней страницы
soup = BeautifulSoup(ur.urlopen(url).read(), 'html.parser')
title = soup.find('h1').text  # Получаем текст заголовка страницы
name = title.split()[-2]  # Извлекаем последнее слово из заголовка, которое предполагается, что это имя
print('Last Name: ', name)
