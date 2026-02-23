using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Nidirana;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Nidirana.unclassified_Nidirana;

/// <summary>
/// Abstract class for unclassified Nidirana (no rank).
/// NCBI TaxId: 2640113
/// </summary>
public abstract class unclassified_Nidirana : Nidirana, Iunclassified_Nidirana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nidirana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640113;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nidirana";
}
