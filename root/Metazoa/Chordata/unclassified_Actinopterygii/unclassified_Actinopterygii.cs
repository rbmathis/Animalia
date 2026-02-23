using AnimalKingdom.root.Metazoa.Chordata;

namespace AnimalKingdom.root.Metazoa.Chordata.unclassified_Actinopterygii;

/// <summary>
/// Abstract class for unclassified Actinopterygii (no rank).
/// NCBI TaxId: 1004024
/// </summary>
public abstract class unclassified_Actinopterygii : Chordata, Iunclassified_Actinopterygii
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Actinopterygii";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1004024;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Actinopterygii";
}
