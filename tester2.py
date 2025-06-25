def get_name(name):
    if len(name) <= 2:
        raise ValueError('You need to enter your complete name.')
    return name
def get_age(age):
    if age > 100:
        raise ValueError('Please enter some value')
    return age


try:
    name = get_name('Mike')
    school_name = get_age('3')
    print(f'{name} is {school_name} years old.')


except ValueError as excpt:
    print(excpt)


except:
    print('Error!')