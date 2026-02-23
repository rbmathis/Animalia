using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae.Tursiops;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae.Tursiops.unclassified_Tursiops;

/// <summary>
/// Abstract class for unclassified Tursiops (no rank).
/// NCBI TaxId: 2643127
/// </summary>
public abstract class unclassified_Tursiops : Tursiops, Iunclassified_Tursiops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tursiops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643127;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tursiops";
}
