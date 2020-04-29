import pandas as pd


# handle categorical data manipulation
def get_categorical_column(data):
    cat_features = data.select_dtypes(include=['object']).copy()
    column_list = cat_features.columns.values.tolist()
    return column_list


def get_replace_map(data):
    columns = get_categorical_column(data)
    data_replace = data.copy()
    for column in columns:
        labels = data[column].astype('category').cat.categories.tolist()
        map = {column: {k: v for k, v in zip(labels, list(range(1, len(labels) + 1)))}}
        data_replace.replace(map, inplace=True)
        data_replace = cast_to_categorical(data_replace)
    return data_replace


def get_one_hot_encoding(data):
    cat_publicity = pd.get_dummies(data, prefix=['classPublicity'])
    # print(cat_publicity.dtypes)
    cat_publicity = cast_to_categorical(cat_publicity)
    # print(cat_publicity.dtypes)
    return cat_publicity



def cast_to_categorical(data):
    non_categorical= data.select_dtypes(include=['object', 'bool', 'uint8']).copy()
    column_list = non_categorical.columns.values.tolist()
    for column in column_list:
        data[column] = data[column].astype('category')
    return data