using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Atelidae.Alouatta;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Atelidae.Alouatta.unclassified_Alouatta;

/// <summary>
/// Abstract class for unclassified Alouatta (no rank).
/// NCBI TaxId: 2623697
/// </summary>
public abstract class unclassified_Alouatta : Alouatta, Iunclassified_Alouatta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Alouatta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623697;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Alouatta";
}
