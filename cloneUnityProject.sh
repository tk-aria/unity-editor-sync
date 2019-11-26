#!/bin/sh

SCRIPT_DIR=$(cd $(dirname $0); pwd)
PROJECT_DIR=$(cd ./; pwd)

PROJECT_NAME="UnityProj_SymbolicLink"

mkdir ../${PROJECT_NAME}
rm -r ../${PROJECT_NAME}/*
CLONE_DIR=$(cd ../${PROJECT_NAME}; pwd)

# シンボリックリンクの対象フォルダー.
folders=("Assets" "Packages" "ProjectSettings" "Library")

# ↓以下処理でシンボリックの作成を行う.
for FOLDER in ${folders[@]}
do
    echo "[ folders ] : "${FOLDER}
    mkdir -p ${CLONE_DIR}/${FOLDER}/
    rm -r ${CLONE_DIR}/${FOLDER}/*
    ln -s ${PROJECT_DIR}/${FOLDER}/* ${CLONE_DIR}/${FOLDER}/
done
