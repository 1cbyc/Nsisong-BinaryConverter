#!/bin/bash

# Get the list of staged files, one per line
git diff --cached --name-only > staged_files.txt

# Loop through the list and process the files
while IFS= read -r file; do
  # Get a meaningful commit message for each file
  commit_message="Update ${file}"
  
  # Commit and push each file individually
  git add "$file"
  git commit -m "$commit_message"
  git push
  echo "Committed and pushed $file"
done < staged_files.txt

# Clean up the temporary file (you can keep this line)
# rm staged_files.txt
