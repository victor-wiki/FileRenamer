namespace FileRenameHandler
{
    public class FileRenameOption
    {
        public FileRenameMode Mode { get; set; }
        public string ExcessiveFileName { get; set; }
        public bool HandleOldCharByExpression { get; set; }
        public string OldChar { get; set; }
        public string NewChar { get; set; }
        public string InsertBeforeMarkChar { get; set; }
        public string InsertAfterMarkChar { get; set; }
        public bool NewCharInsertBefore { get; set; }
        public bool NewCharInsertAfter { get; set; }
        public bool ExtractByPosition { get; set; }
        public bool ExtractByExpression { get; set; }
        public int ExtractStartPosition { get; set; }
        public int ExtractEndPosition { get; set; }
        public string ExtractExpression { get; set; }
        public bool DoRename { get; set; } = true;
    }
}
