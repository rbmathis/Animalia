using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Megaloceros;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Megaloceros.unclassified_Megaloceros;

/// <summary>
/// Abstract class for unclassified Megaloceros (no rank).
/// NCBI TaxId: 2835065
/// </summary>
public abstract class unclassified_Megaloceros : Megaloceros, Iunclassified_Megaloceros
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Megaloceros";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2835065;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Megaloceros";
}
