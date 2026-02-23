using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Saproscincus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Saproscincus.unclassified_Saproscincus;

/// <summary>
/// Abstract class for unclassified Saproscincus (no rank).
/// NCBI TaxId: 2623982
/// </summary>
public abstract class unclassified_Saproscincus : Saproscincus, Iunclassified_Saproscincus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Saproscincus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623982;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Saproscincus";
}
