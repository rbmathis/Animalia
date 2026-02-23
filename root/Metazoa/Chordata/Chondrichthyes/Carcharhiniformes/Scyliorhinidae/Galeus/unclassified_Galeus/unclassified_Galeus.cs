using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae.Galeus;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae.Galeus.unclassified_Galeus;

/// <summary>
/// Abstract class for unclassified Galeus (no rank).
/// NCBI TaxId: 2642408
/// </summary>
public abstract class unclassified_Galeus : Galeus, Iunclassified_Galeus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Galeus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2642408;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Galeus";
}
