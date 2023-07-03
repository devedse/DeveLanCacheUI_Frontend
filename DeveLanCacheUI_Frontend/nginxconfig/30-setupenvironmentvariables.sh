# if [[ -z "${APIBASEURL}" ]]; then
#     echo Could not find APIBASEURL. Exiting setupenvironmentscript
#     exit
# fi

cat > /usr/share/nginx/html/environment.js << EOL
window.ENV = {
    "BACKENDURL": "$BACKENDURL"
}
EOL