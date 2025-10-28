def main():
    running = True
    print("Welcome to PCU v2 assist!")
    while running:
        command = input("What would you like to do? (\'H\' for help): ").lower()
        if command == 'h':
            print("\'H\' to show this list")
            print("\'R\' to reset your pokedex")
            print("\'F [category 1] [category 2]\' to filter on two categories")
            print("\'S [name of pokemon]\' to declare a pokemon as shiny")
            print("\'Q\' to exit the program")
        elif command == 'r':
            print("WIP")
        elif command == 'f':
            print("WIP")
        elif command == 's':
            print("WIP")
        elif command.startswith('q'):
            print("Thanks for using!")
            running = False
        else:
            print("Invalid input")


if __name__ == '__main__':
    main()
