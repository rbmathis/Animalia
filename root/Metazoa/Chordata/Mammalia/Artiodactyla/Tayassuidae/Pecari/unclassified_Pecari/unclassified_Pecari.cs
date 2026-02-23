using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Tayassuidae.Pecari;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Tayassuidae.Pecari.unclassified_Pecari;

/// <summary>
/// Abstract class for unclassified Pecari (no rank).
/// NCBI TaxId: 2643835
/// </summary>
public abstract class unclassified_Pecari : Pecari, Iunclassified_Pecari
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pecari";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643835;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pecari";
}
