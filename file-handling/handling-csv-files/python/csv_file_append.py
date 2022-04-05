# Isaac Computer Science
# Usage licensed under the Open Government Licence v3.0


def append_movie():
    """Append a new record to the CSV file"""
    new_movie = "Spider-Man: No Way Home,2021,148,Jon Watts,8.6,793.9"
    file_object = open("movies.csv", mode="a")
    file_object.write(new_movie)
    file_object.write("\n")
    file_object.close()


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    append_movie()
