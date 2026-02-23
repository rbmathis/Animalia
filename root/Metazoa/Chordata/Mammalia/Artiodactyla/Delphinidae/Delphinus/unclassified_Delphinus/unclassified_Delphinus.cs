using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae.Delphinus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae.Delphinus.unclassified_Delphinus;

/// <summary>
/// Abstract class for unclassified Delphinus (no rank).
/// NCBI TaxId: 2684924
/// </summary>
public abstract class unclassified_Delphinus : Delphinus, Iunclassified_Delphinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Delphinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2684924;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Delphinus";
}
