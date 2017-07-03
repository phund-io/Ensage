namespace FlameFramework
{
    using System;
    using System.ComponentModel.Composition;

    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class)]
    public class ExportFlameDictionaryAttribute : ExportAttribute, IFlameDictionaryMetadata
    {
        public ExportFlameDictionaryAttribute(string name, string author = null)
            : base(typeof(IFlameDictionary))
        {
            this.Name = name;
            this.Author = author;
        }

        public string Author { get; }

        public string Name { get; }
    }
}