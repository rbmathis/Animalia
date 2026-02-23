using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Spermophilus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Spermophilus.unclassified_Spermophilus;

/// <summary>
/// Abstract class for unclassified Spermophilus (no rank).
/// NCBI TaxId: 2643561
/// </summary>
public abstract class unclassified_Spermophilus : Spermophilus, Iunclassified_Spermophilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Spermophilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643561;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Spermophilus";
}
