import requests
r = requests.get('https://api.census.gov/data/2020/acs/acs5?get=NAME,B08303_001E,B08303_013E&for=state:*')

print(r.text)
print('_________________________________________')
print(r.json())
