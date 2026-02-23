using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Sphaerodactylidae.Pristurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Sphaerodactylidae.Pristurus.unclassified_Pristurus;

/// <summary>
/// Abstract class for unclassified Pristurus (no rank).
/// NCBI TaxId: 2639161
/// </summary>
public abstract class unclassified_Pristurus : Pristurus, Iunclassified_Pristurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pristurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639161;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pristurus";
}
