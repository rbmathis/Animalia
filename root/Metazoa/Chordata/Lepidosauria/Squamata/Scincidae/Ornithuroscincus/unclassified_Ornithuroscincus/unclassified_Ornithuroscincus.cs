using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Ornithuroscincus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Ornithuroscincus.unclassified_Ornithuroscincus;

/// <summary>
/// Abstract class for unclassified Ornithuroscincus (no rank).
/// NCBI TaxId: 2878433
/// </summary>
public abstract class unclassified_Ornithuroscincus : Ornithuroscincus, Iunclassified_Ornithuroscincus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ornithuroscincus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2878433;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ornithuroscincus";
}
