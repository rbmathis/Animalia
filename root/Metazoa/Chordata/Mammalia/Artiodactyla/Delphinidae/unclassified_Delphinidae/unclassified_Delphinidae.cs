using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae.unclassified_Delphinidae;

/// <summary>
/// Abstract class for unclassified Delphinidae (no rank).
/// NCBI TaxId: 49272
/// </summary>
public abstract class unclassified_Delphinidae : Delphinidae, Iunclassified_Delphinidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Delphinidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 49272;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Delphinidae";
}
