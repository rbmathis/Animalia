using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Lythrypnus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Lythrypnus.unclassified_Lythrypnus;

/// <summary>
/// Abstract class for unclassified Lythrypnus (no rank).
/// NCBI TaxId: 2628946
/// </summary>
public abstract class unclassified_Lythrypnus : Lythrypnus, Iunclassified_Lythrypnus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lythrypnus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2628946;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lythrypnus";
}
