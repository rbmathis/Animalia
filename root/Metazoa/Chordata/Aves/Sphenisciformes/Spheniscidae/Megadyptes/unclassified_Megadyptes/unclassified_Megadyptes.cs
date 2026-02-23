using AnimalKingdom.root.Metazoa.Chordata.Aves.Sphenisciformes.Spheniscidae.Megadyptes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Sphenisciformes.Spheniscidae.Megadyptes.unclassified_Megadyptes;

/// <summary>
/// Abstract class for unclassified Megadyptes (no rank).
/// NCBI TaxId: 2618593
/// </summary>
public abstract class unclassified_Megadyptes : Megadyptes, Iunclassified_Megadyptes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Megadyptes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618593;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Megadyptes";
}
