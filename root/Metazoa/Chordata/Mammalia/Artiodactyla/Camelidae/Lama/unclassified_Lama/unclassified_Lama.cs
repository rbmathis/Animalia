using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Camelidae.Lama;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Camelidae.Lama.unclassified_Lama;

/// <summary>
/// Abstract class for unclassified Lama (no rank).
/// NCBI TaxId: 3396595
/// </summary>
public abstract class unclassified_Lama : Lama, Iunclassified_Lama
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lama";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3396595;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lama";
}
