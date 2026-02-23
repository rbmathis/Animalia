using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.unclassified_Cetacea;

/// <summary>
/// Abstract class for unclassified Cetacea (no rank).
/// NCBI TaxId: 727676
/// </summary>
public abstract class unclassified_Cetacea : Artiodactyla, Iunclassified_Cetacea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cetacea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 727676;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cetacea";
}
