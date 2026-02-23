using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Spalacidae.Tachyoryctes;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Spalacidae.Tachyoryctes.unclassified_Tachyoryctes;

/// <summary>
/// Abstract class for unclassified Tachyoryctes (no rank).
/// NCBI TaxId: 2618128
/// </summary>
public abstract class unclassified_Tachyoryctes : Tachyoryctes, Iunclassified_Tachyoryctes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tachyoryctes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618128;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tachyoryctes";
}
