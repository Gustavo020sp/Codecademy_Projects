#original poem
highlighted_poems = "Afterimages:Audre Lorde:1997,  The Shadow:William Carlos Williams:1915, Ecstasy:Gabriela Mistral:1925,   Georgia Dusk:Jean Toomer:1923,   Parting Before Daybreak:An Qi:2014, The Untold Want:Walt Whitman:1871, Mr. Grumpledump's Song:Shel Silverstein:2004, Angel Sound Mexico City:Carmen Boullosa:2013, In Love:Kamala Suraiyya:1965, Dream Variations:Langston Hughes:1994, Dreamwood:Adrienne Rich:1987"
#print(highlighted_poems)

#separate the lists with commas
highlighted_poems_list = highlighted_poems.split(',')
#print(highlighted_poems_list)

highlighted_poems_stripped = []
for p in highlighted_poems_list:
  highlighted_poems_stripped.append(p.strip()) #cleans off whitespaces
#print(highlighted_poems_stripped)

highlighted_poems_details = []
for ps in highlighted_poems_stripped:
  highlighted_poems_details.append(ps.split(':')) #removes the dots and whitespaces from each item in the list
#print(highlighted_poems_details)

titles = []
poets = []
dates = []

for pd in highlighted_poems_details: #access each item in the  above, and appends to the proper list accessing by the index
  titles.append(pd[0])
  poets.append(pd[1])
  dates.append(pd[2])

for i in range(0,len(highlighted_poems_details)):
  msg = "The poem {} was published by {} in {}".format(titles[i],poets[i],dates[i])
  print(msg)
  i += 1
