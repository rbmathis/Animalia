using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Nectariniidae.Nectarinia;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Nectariniidae.Nectarinia.unclassified_Nectarinia;

/// <summary>
/// Abstract class for unclassified Nectarinia (no rank).
/// NCBI TaxId: 2624528
/// </summary>
public abstract class unclassified_Nectarinia : Nectarinia, Iunclassified_Nectarinia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nectarinia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624528;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nectarinia";
}
