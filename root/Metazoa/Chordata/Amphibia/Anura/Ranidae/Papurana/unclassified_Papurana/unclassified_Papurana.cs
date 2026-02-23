using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Papurana;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Papurana.unclassified_Papurana;

/// <summary>
/// Abstract class for unclassified Papurana (no rank).
/// NCBI TaxId: 2628808
/// </summary>
public abstract class unclassified_Papurana : Papurana, Iunclassified_Papurana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Papurana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2628808;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Papurana";
}
