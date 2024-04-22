using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace FileRenameHandler
{
    public class FileRenameProcessor
    {
        public FileRenameOption Option { get; set; } = new FileRenameOption();

        public FileRenameProcessor(FileRenameOption option)
        {
            this.Option = option;
        }

        public string Rename(FileInfo file, out string errMsg)
        {
            errMsg = "";

            FileRenameMode mode = this.Option.Mode;

            string oldChar = this.Option.OldChar;
            string newChar = this.Option.NewChar;

            string fileName = Path.GetFileNameWithoutExtension(file.Name);
            string newFileName = "";

            if (!string.IsNullOrEmpty(this.Option.ExcessiveFileName))
            {
                fileName = this.Option.ExcessiveFileName;
            }

            try
            {
                if (mode == FileRenameMode.RemoveOrReplace)
                {
                    if (!this.Option.HandleOldCharByExpression)
                    {
                        newFileName = fileName.Replace(oldChar, newChar);
                    }
                    else
                    {
                        if (this.CheckExpression(oldChar, out errMsg))
                        {
                            bool matched = false;

                            string result = this.HandleExpressioin(oldChar, fileName, out matched);

                            if(matched)
                            {
                                newFileName = fileName.Replace(result, newChar);
                            }
                            else
                            {
                                newFileName = result;
                            }                            
                        }
                        else
                        {
                            return file.Name;
                        }
                    }
                }
                else if (mode == FileRenameMode.Trim)
                {
                    newFileName = fileName.Trim(oldChar.ToArray());
                }
                else if (mode == FileRenameMode.Insert || mode == FileRenameMode.InsertFolderName)
                {
                    string insertChar = newChar;

                    string insertBeforeChar = this.Option.InsertBeforeMarkChar;
                    string insertAfterChar = this.Option.InsertAfterMarkChar;

                    int insertBeforeIndex = -1;
                    int insertAfterIndex = -1;

                    if (!string.IsNullOrEmpty(insertBeforeChar))
                    {
                        insertBeforeIndex = fileName.IndexOf(insertBeforeChar);
                    }
                    else
                    {
                        insertBeforeIndex = 0;
                    }

                    if (!string.IsNullOrEmpty(insertAfterChar))
                    {
                        insertAfterIndex = fileName.IndexOf(insertAfterChar);
                    }

                    if (this.Option.NewCharInsertBefore)
                    {
                        if (insertBeforeIndex != -1)
                        {
                            newFileName = fileName.Substring(0, insertBeforeIndex) + newChar + fileName.Substring(insertBeforeIndex);
                        }
                        else
                        {
                            newFileName = newChar + fileName;
                        }
                    }
                    else
                    {
                        if (insertAfterIndex != -1)
                        {
                            newFileName = fileName.Substring(0, insertAfterIndex + insertAfterChar.Length) + newChar + fileName.Substring(insertAfterIndex + insertAfterChar.Length);
                        }
                        else
                        {
                            newFileName = fileName + insertChar;
                        }
                    }
                }
                else if (mode == FileRenameMode.Extract)
                {
                    if (this.Option.ExtractByPosition)
                    {
                        int startPos = this.Option.ExtractStartPosition;
                        int endPos = this.Option.ExtractEndPosition;

                        if (startPos <= fileName.Length)
                        {
                            newFileName = fileName.Substring(startPos - 1, endPos <= 0 ? fileName.Length - startPos + 1 : endPos - startPos + 1);
                        }
                    }
                    else if (this.Option.ExtractByExpression)
                    {
                        string expression = this.Option.ExtractExpression;
                        if (this.CheckExpression(expression, out errMsg))
                        {
                            newFileName = this.HandleExpressioin(expression, fileName, out _);
                        }
                        else
                        {
                            return file.Name;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                errMsg = $"Error occurs when handle \"{file.Name}\":{ex.Message}";
                return file.Name;
            }

            newFileName += file.Extension;

            if (string.IsNullOrEmpty(errMsg) && !string.IsNullOrEmpty(newFileName) && newFileName != fileName && this.Option.DoRename)
            {
                string newFilePath = Path.Combine(file.DirectoryName, newFileName);
                if (!File.Exists(newFilePath))
                {
                    file.MoveTo(newFilePath);
                }
            }

            return newFileName;
        }

        private bool CheckExpression(string expression, out string msg)
        {
            msg = "";
            if (string.IsNullOrEmpty(expression) || expression.Length < 2)
            {
                msg = "The expression can't be empty and the length of it can't be less 2.";
                return false;
            }
            return true;
        }

        private string HandleExpressioin(string expression, string fileName, out bool matched)
        {
            matched = false;

            Regex reg = new Regex(expression, RegexOptions.IgnoreCase);
            MatchCollection matches = reg.Matches(fileName);
            if (matches.Count > 0)
            {
                matched = true;

                return matches[0].Value;
            }
            return fileName;
        }
    }
}