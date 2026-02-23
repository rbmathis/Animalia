using AnimalKingdom.root.Metazoa.Chordata.Testudines.Kinosternidae.Kinosternon;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Kinosternidae.Kinosternon.unclassified_Kinosternon;

/// <summary>
/// Abstract class for unclassified Kinosternon (no rank).
/// NCBI TaxId: 3467912
/// </summary>
public abstract class unclassified_Kinosternon : Kinosternon, Iunclassified_Kinosternon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Kinosternon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3467912;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Kinosternon";
}
