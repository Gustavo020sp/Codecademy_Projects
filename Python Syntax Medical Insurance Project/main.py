# create the initial variables below
age = 28
sex = 0 #female
bmi = 26.2
num_of_children = 3
smoker = 0 #non-smoker

# Add insurance estimate formula below
insurance_cost = 250 * age - 128 * sex + 370 * bmi + 425 * num_of_children + 24000 * smoker - 12500
print("this person's insurance cost is " + str(insurance_cost) +" dollars")

# Age Factor
age += 4
new_insurance_cost = 250 * age - 128 * sex + 370 * bmi + 425 * num_of_children + 24000 * smoker - 12500

change_in_insurance_cost = new_insurance_cost - insurance_cost
print("The change in cost of insurance after increasing the age by 4 years is " + str(change_in_insurance_cost) + " dollars.")

# BMI Factor
age = 28
bmi += 3.1
new_insurance_cost = 250 * age - 128 * sex + 370 * bmi + 425 * num_of_children + 24000 * smoker - 12500
change_in_insurance_cost =  insurance_cost - new_insurance_cost
print("The change in cost of insurance after increasing the bmi by 3.1 is " + str(change_in_insurance_cost) + " dollars.")

# Male vs. Female Factor
sex = 1
new_insurance_cost = 250 * age - 128 * sex + 370 * bmi + 425 * num_of_children + 24000 * smoker - 12500
change_in_insurance_cost =  insurance_cost - new_insurance_cost
print("The change in estimated cost for being male instead of female is " + str(change_in_insurance_cost) + " dollars.")

# Extra Practice
#number of children factor
num_of_children = 1
new_insurance_cost = 250 * age - 128 * sex + 370 * bmi + 425 * num_of_children + 24000 * smoker - 12500
change_in_insurance_cost =  insurance_cost - new_insurance_cost
print("The change in estimated cost for having 1 children instead of 3 childrens is " + str(change_in_insurance_cost) + " dollars.")

