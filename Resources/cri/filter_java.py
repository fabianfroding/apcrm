import os
import shutil
import sys


def filter_java_only(source_dir, new_path):
    # listing file with .java extension
    print(source_dir)
    for dirpath, dirnames, filenames in os.walk(source_dir):
        for f in filenames:
            if f.endswith(".java"):
                old_full_path = r"{}\{}".format(dirpath, f)
                # print(old_full_path)
                new_full_path = old_full_path.replace(source_dir, new_path)
                # print(new_full_path)
                os.makedirs(os.path.dirname(new_full_path), exist_ok=True)
                shutil.copy(old_full_path, new_full_path)
                print("{} copied".format(old_full_path))


if __name__ == "__main__":

    if len(sys.argv) != 3:
        sys.exit("Please follow this format: python filter_java.py <source_directory> <destination_directory")

    if len(sys.argv) == 3:
        # source_dir = os.path.dirname(sys.argv[1])
        source_dir = sys.argv[1]
        dest_dir = sys.argv[2]
        filter_java_only(source_dir, dest_dir)
