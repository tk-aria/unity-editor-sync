
#!/bin/sh
SCRIPT_DIR=$(cd $(dirname $0); pwd)
cd ${SCRIPT_DIR}
sh "`dirname "$0"`"/setupSynchronizableProject.sh
