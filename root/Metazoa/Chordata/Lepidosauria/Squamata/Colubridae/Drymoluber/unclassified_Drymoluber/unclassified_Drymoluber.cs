using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Drymoluber;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Drymoluber.unclassified_Drymoluber;

/// <summary>
/// Abstract class for unclassified Drymoluber (no rank).
/// NCBI TaxId: 2649297
/// </summary>
public abstract class unclassified_Drymoluber : Drymoluber, Iunclassified_Drymoluber
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Drymoluber";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649297;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Drymoluber";
}
