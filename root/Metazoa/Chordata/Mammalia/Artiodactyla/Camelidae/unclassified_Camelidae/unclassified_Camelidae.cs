using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Camelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Camelidae.unclassified_Camelidae;

/// <summary>
/// Abstract class for unclassified Camelidae (no rank).
/// NCBI TaxId: 1579310
/// </summary>
public abstract class unclassified_Camelidae : Camelidae, Iunclassified_Camelidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Camelidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1579310;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Camelidae";
}
