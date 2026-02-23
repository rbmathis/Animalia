using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Taterillus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Taterillus.unclassified_Taterillus;

/// <summary>
/// Abstract class for unclassified Taterillus (no rank).
/// NCBI TaxId: 2622129
/// </summary>
public abstract class unclassified_Taterillus : Taterillus, Iunclassified_Taterillus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Taterillus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622129;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Taterillus";
}
