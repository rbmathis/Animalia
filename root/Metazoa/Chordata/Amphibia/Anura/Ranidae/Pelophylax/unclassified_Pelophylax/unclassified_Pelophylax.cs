using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Pelophylax;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Pelophylax.unclassified_Pelophylax;

/// <summary>
/// Abstract class for unclassified Pelophylax (no rank).
/// NCBI TaxId: 2632152
/// </summary>
public abstract class unclassified_Pelophylax : Pelophylax, Iunclassified_Pelophylax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pelophylax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632152;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pelophylax";
}
