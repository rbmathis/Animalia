using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Kobus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Kobus.unclassified_Kobus;

/// <summary>
/// Abstract class for unclassified Kobus (no rank).
/// NCBI TaxId: 3056449
/// </summary>
public abstract class unclassified_Kobus : Kobus, Iunclassified_Kobus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Kobus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3056449;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Kobus";
}
