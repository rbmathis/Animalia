using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Metamagnusia;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Metamagnusia.unclassified_Metamagnusia;

/// <summary>
/// Abstract class for unclassified Metamagnusia (no rank).
/// NCBI TaxId: 2862817
/// </summary>
public abstract class unclassified_Metamagnusia : Metamagnusia, Iunclassified_Metamagnusia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Metamagnusia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2862817;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Metamagnusia";
}
