"""Calling a JSON API

In this assignment you will write a Python program somewhat similar to http://www.py4e.com/code3/geojson.py. The program will prompt for a location, contact a web service and retrieve JSON for the web service and parse that data, and retrieve the first place_id from the JSON. A place ID is a textual identifier that uniquely identifies a place as within Google Maps.
API End Points

To complete this assignment, you should use this API endpoint that has a static subset of the Google Data:

http://py4e-data.dr-chuck.net/geojson?
This API uses the same parameter (address) as the Google API. This API also has no rate limit so you can test as often as you like. If you visit the URL with no parameters, you get a list of all of the address values which can be used with this API.
To call the API, you need to provide address that you are requesting as the address= parameter that is properly URL encoded using the urllib.urlencode() fuction as shown in http://www.py4e.com/code3/geojson.py"""



#Enter location: University of Twente
#Retrieving  http://python-data.dr-chuck.net/geojson?#sensor=false&address=University+of+Twente
#Retrieved 2124 characters
#Place id ChIJPZ9qp0tvv4cRb5oLVI9wra8


import urllib.request as ur
import urllib.parse as up
import json

serviceurl = "http://python-data.dr-chuck.net/geojson?"

# Вставьте свой список адресов здесь
addresses = [
  "University of Belgrade"
]

for address in addresses:
    params = {"sensor": "false", "address": address}
    url = serviceurl + up.urlencode(params)
    print("____\nRetrieving ", url)
    data = ur.urlopen(url).read().decode('utf-8')
    #print('Retrieved', len(data), 'characters')
    json_obj = json.loads(data)

    place_id = json_obj["results"][0]["place_id"]
    print("\nPlace id for", place_id)

