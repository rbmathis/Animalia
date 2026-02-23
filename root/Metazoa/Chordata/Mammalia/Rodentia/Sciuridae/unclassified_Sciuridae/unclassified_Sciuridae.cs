using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.unclassified_Sciuridae;

/// <summary>
/// Abstract class for unclassified Sciuridae (no rank).
/// NCBI TaxId: 1002716
/// </summary>
public abstract class unclassified_Sciuridae : Sciuridae, Iunclassified_Sciuridae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sciuridae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1002716;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sciuridae";
}
