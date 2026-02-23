using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Peramelemorphia.Peroryctidae.Microperoryctes;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Peramelemorphia.Peroryctidae.Microperoryctes.unclassified_Microperoryctes;

/// <summary>
/// Abstract class for unclassified Microperoryctes (no rank).
/// NCBI TaxId: 2631057
/// </summary>
public abstract class unclassified_Microperoryctes : Microperoryctes, Iunclassified_Microperoryctes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Microperoryctes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631057;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Microperoryctes";
}
