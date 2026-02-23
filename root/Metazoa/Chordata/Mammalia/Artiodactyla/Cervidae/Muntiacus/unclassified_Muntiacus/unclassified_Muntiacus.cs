using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Muntiacus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Muntiacus.unclassified_Muntiacus;

/// <summary>
/// Abstract class for unclassified Muntiacus (no rank).
/// NCBI TaxId: 2620652
/// </summary>
public abstract class unclassified_Muntiacus : Muntiacus, Iunclassified_Muntiacus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Muntiacus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620652;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Muntiacus";
}
