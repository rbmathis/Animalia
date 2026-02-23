using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Atractus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Atractus.unclassified_Atractus;

/// <summary>
/// Abstract class for unclassified Atractus (no rank).
/// NCBI TaxId: 2634965
/// </summary>
public abstract class unclassified_Atractus : Atractus, Iunclassified_Atractus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Atractus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634965;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Atractus";
}
