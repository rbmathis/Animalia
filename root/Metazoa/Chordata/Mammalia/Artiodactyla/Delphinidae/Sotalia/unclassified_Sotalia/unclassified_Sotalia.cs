using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae.Sotalia;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae.Sotalia.unclassified_Sotalia;

/// <summary>
/// Abstract class for unclassified Sotalia (no rank).
/// NCBI TaxId: 2634352
/// </summary>
public abstract class unclassified_Sotalia : Sotalia, Iunclassified_Sotalia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sotalia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634352;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sotalia";
}
