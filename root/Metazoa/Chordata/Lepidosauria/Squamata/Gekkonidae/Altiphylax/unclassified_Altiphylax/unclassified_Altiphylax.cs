using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Altiphylax;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Altiphylax.unclassified_Altiphylax;

/// <summary>
/// Abstract class for unclassified Altiphylax (no rank).
/// NCBI TaxId: 2796534
/// </summary>
public abstract class unclassified_Altiphylax : Altiphylax, Iunclassified_Altiphylax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Altiphylax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2796534;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Altiphylax";
}
