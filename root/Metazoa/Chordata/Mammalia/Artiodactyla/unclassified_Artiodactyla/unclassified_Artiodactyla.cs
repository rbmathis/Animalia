using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.unclassified_Artiodactyla;

/// <summary>
/// Abstract class for unclassified Artiodactyla (no rank).
/// NCBI TaxId: 948947
/// </summary>
public abstract class unclassified_Artiodactyla : Artiodactyla, Iunclassified_Artiodactyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Artiodactyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 948947;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Artiodactyla";
}
