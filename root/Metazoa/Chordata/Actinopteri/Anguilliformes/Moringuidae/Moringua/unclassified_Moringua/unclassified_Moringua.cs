using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Moringuidae.Moringua;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Moringuidae.Moringua.unclassified_Moringua;

/// <summary>
/// Abstract class for unclassified Moringua (no rank).
/// NCBI TaxId: 2633452
/// </summary>
public abstract class unclassified_Moringua : Moringua, Iunclassified_Moringua
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Moringua";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633452;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Moringua";
}
