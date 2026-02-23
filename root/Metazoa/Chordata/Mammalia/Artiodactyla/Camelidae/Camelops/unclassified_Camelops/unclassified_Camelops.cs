using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Camelidae.Camelops;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Camelidae.Camelops.unclassified_Camelops;

/// <summary>
/// Abstract class for unclassified Camelops (no rank).
/// NCBI TaxId: 2984907
/// </summary>
public abstract class unclassified_Camelops : Camelops, Iunclassified_Camelops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Camelops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2984907;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Camelops";
}
