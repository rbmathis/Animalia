using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Micrurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Micrurus.unclassified_Micrurus;

/// <summary>
/// Abstract class for unclassified Micrurus (no rank).
/// NCBI TaxId: 2620925
/// </summary>
public abstract class unclassified_Micrurus : Micrurus, Iunclassified_Micrurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Micrurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620925;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Micrurus";
}
