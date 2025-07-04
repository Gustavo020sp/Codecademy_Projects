names = ["Judith", "Abel", "Tyson", "Martha", "Beverley", "David", "Anabel"]
estimated_insurance_costs = [1000.0, 2000.0, 3000.0, 4000.0, 5000.0, 6000.0, 7000.0]
actual_insurance_costs = [1100.0, 2200.0, 3300.0, 4400.0, 5500.0, 6600.0, 7700.0]

total_cost = 0
for cost in actual_insurance_costs:
    total_cost += cost
print(f"Total cost for while loop: {total_cost}")

# converting the first for loop into a while loop
while total_cost <= actual_insurance_costs[-1]:
    total_cost += actual_insurance_costs[-1]
print(f"Total cost for while loop: {total_cost}")

average_cost = total_cost / len(actual_insurance_costs)
print(f"Average Insurance Cost: {average_cost} dollars.\n")

#this iteration creates two variables to loop and print values from insurance and names list
for i in range(len(names)):
    name = names[i]
    insurance_cost = actual_insurance_costs[i]
    difference = abs(average_cost - insurance_cost)
    print(f"The insurance cost for {name} is {insurance_cost} dollars.")
    if insurance_cost > average_cost:
        print(f"The insurance cost for {name} is above average in {difference} dollars.\n")
    elif insurance_cost < average_cost:
        print(f"The insurance cost for {name} is below average in {difference} dollars.\n")
    else:
        print(f"The insurance cost for {name} is equal to average in {difference} dollars.\n")

updated_insurance_costs = [i * 11/10 for i in estimated_insurance_costs]
print(updated_insurance_costs)




