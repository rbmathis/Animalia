using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Ninia;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Ninia.unclassified_Ninia;

/// <summary>
/// Abstract class for unclassified Ninia (no rank).
/// NCBI TaxId: 2624686
/// </summary>
public abstract class unclassified_Ninia : Ninia, Iunclassified_Ninia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ninia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624686;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ninia";
}
