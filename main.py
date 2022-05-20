# This is a sample Python script.

# Press Shift+F10 to execute it or replace it with your code.
# Press Double Shift to search everywhere for classes, files, tool windows, actions, and settings.
import argparse
import os.path

def print_hi(name):
    # Use a breakpoint in the code line below to debug your script.
    print(f'Hi, {name}')  # Press Ctrl+F8 to toggle the breakpoint.
def data_parse(my_list):

    myres=[]
    for m in my_list:
        if len(m)<=3:
            myres.append(m)
    print(myres)

# Press the green button in the gutter to run the script.
if __name__ == '__main__':
    my_list = ["hello", "2", "world", ":-)"]
    my_list2 = ["1234", "1567", "-2", "computer science"]
    my_list3 = ["Russia", "Denmark", "Kazan"]
    #print_hi('PyCharm')
    data_parse(my_list2)
# See PyCharm help at https://www.jetbrains.com/help/pycharm/
