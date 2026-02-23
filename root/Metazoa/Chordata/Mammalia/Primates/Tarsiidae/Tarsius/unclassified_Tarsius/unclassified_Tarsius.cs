using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Tarsiidae.Tarsius;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Tarsiidae.Tarsius.unclassified_Tarsius;

/// <summary>
/// Abstract class for unclassified Tarsius (no rank).
/// NCBI TaxId: 2624233
/// </summary>
public abstract class unclassified_Tarsius : Tarsius, Iunclassified_Tarsius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tarsius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624233;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tarsius";
}
