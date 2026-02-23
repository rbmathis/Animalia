using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Coluber;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Coluber.unclassified_Coluber;

/// <summary>
/// Abstract class for unclassified Coluber (no rank).
/// NCBI TaxId: 2627826
/// </summary>
public abstract class unclassified_Coluber : Coluber, Iunclassified_Coluber
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Coluber";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2627826;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Coluber";
}
