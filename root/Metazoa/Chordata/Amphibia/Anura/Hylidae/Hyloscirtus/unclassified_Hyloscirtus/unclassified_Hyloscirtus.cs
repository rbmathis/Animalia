using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Hyloscirtus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Hyloscirtus.unclassified_Hyloscirtus;

/// <summary>
/// Abstract class for unclassified Hyloscirtus (no rank).
/// NCBI TaxId: 2642466
/// </summary>
public abstract class unclassified_Hyloscirtus : Hyloscirtus, Iunclassified_Hyloscirtus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hyloscirtus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2642466;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hyloscirtus";
}
