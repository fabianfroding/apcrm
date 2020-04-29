import sys
import pickle
import pandas as pd
import categorical_util as cu
import numpy as np


def process(model_file, feature_file, output_file):
    # print("{}, {}, {}".format(model_file, target_file, output_file))

    # opening the model file
    model = pickle.load(open(model_file, 'rb'))
    feature_df = pd.read_csv(feature_file, index_col="index")
    # print(feature_df.dtypes)

    # removing non-feature columns
    features = feature_df.drop(columns=['fullpathname', 'classname'])
    # print(features.dtypes)

    # replace categorical features with one hot encoding
    features_ohc = cu.get_one_hot_encoding(features)
    # print(features_ohc.dtypes)

    # check if one hot encoding for class publicity all exists
    if 'classPublicity_public' not in features_ohc.columns:
        add_features = pd.DataFrame(0, index=np.arange(len(features_ohc)), columns=['classPublicity_public']).astype(
            'category')
        features_ohc = features_ohc.join(add_features)

    if 'classPublicity_private' not in features_ohc.columns:
        add_features = pd.DataFrame(0, index=np.arange(len(features_ohc)), columns=['classPublicity_private']).astype(
            'category')
        features_ohc = features_ohc.join(add_features)

    if 'classPublicity_protected' not in features_ohc.columns:
        add_features = pd.DataFrame(0, index=np.arange(len(features_ohc)), columns=['classPublicity_protected']).astype(
            'category')
        features_ohc = features_ohc.join(add_features)

    if 'classPublicity_default' not in features_ohc.columns:
        add_features = pd.DataFrame(0, index=np.arange(len(features_ohc)), columns=['classPublicity_default']).astype(
            'category')
        features_ohc = features_ohc.join(add_features)

    # print(features_ohc.dtypes)

    # classifying feature files
    labels = model.predict(features_ohc)

    feature_df.loc[:, 'pred_label'] = pd.Series(labels, index=features_ohc.index)

    # Save the classified file
    feature_df.to_csv(output_file, sep=',', index=True)


if __name__ == "__main__":

    if len(sys.argv) != 4:
        sys.exit("Please follow this format: python classifier.py <model_file.sav> <feature_file.csv> <output_file.csv>")

    if len(sys.argv) == 4:
        model_file = sys.argv[1]
        feature_file = sys.argv[2]
        output_file = sys.argv[3]
        process(model_file, feature_file, output_file)
