using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Batis;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Batis.unclassified_Batis_in_birds;

/// <summary>
/// Abstract class for unclassified Batis (in: birds) (no rank).
/// NCBI TaxId: 2688275
/// </summary>
public abstract class unclassified_Batis_in_birds : Batis, Iunclassified_Batis_in_birds
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Batis (in: birds)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2688275;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Batis_in_birds";
}
