# Raspberry Pi Foundation
# Developed to be used alongside Isaac Computer Science,
# part of the National Centre for Computing Education
# Usage licensed under CC BY-SA 4

def main():
    print("Enter a test score")
    user_input = input()
    test_score = int(user_input)

    if test_score >= 60:
        print("Pass")
    else:
        print("Retry")

    print("End of program")


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == '__main__':
    main()
