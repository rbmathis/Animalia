using AnimalKingdom.root.Metazoa.Chordata.Aves.Sphenisciformes.Spheniscidae.Eudyptes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Sphenisciformes.Spheniscidae.Eudyptes.unclassified_Eudyptes;

/// <summary>
/// Abstract class for unclassified Eudyptes (no rank).
/// NCBI TaxId: 2617890
/// </summary>
public abstract class unclassified_Eudyptes : Eudyptes, Iunclassified_Eudyptes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Eudyptes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2617890;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Eudyptes";
}
