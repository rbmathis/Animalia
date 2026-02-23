using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Aphyocheirodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Aphyocheirodon.unclassified_Aphyocheirodon;

/// <summary>
/// Abstract class for unclassified Aphyocheirodon (no rank).
/// NCBI TaxId: 2640623
/// </summary>
public abstract class unclassified_Aphyocheirodon : Aphyocheirodon, Iunclassified_Aphyocheirodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Aphyocheirodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640623;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Aphyocheirodon";
}
