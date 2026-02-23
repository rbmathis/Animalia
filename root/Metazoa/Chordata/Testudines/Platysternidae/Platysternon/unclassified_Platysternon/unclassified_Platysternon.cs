using AnimalKingdom.root.Metazoa.Chordata.Testudines.Platysternidae.Platysternon;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Platysternidae.Platysternon.unclassified_Platysternon;

/// <summary>
/// Abstract class for unclassified Platysternon (no rank).
/// NCBI TaxId: 3452348
/// </summary>
public abstract class unclassified_Platysternon : Platysternon, Iunclassified_Platysternon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Platysternon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3452348;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Platysternon";
}
