paintings = ['The Two Fridas', 'My Dress Hangs Here', 'Tree of Hope', 'Self Portrait With Monkeys']

dates = ['1939','1933', '1946', '1940']

paintings.append('The Broken Column')
paintings.append('The Wounded Deer')
paintings.append('Me and My Doll')

dates.append('1944')
dates.append('1946')
dates.append('1937')

new_list = zip(paintings, dates)

print(list(new_list))

painting_length = len(paintings)

audio_tour_number = range(1, painting_length)
print(audio_tour_number)

master_list = zip(paintings, audio_tour_number)

print(list(master_list))