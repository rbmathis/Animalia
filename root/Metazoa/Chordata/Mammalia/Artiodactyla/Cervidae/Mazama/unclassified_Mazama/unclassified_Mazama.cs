using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Mazama;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Mazama.unclassified_Mazama;

/// <summary>
/// Abstract class for unclassified Mazama (no rank).
/// NCBI TaxId: 2622720
/// </summary>
public abstract class unclassified_Mazama : Mazama, Iunclassified_Mazama
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mazama";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622720;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mazama";
}
