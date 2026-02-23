using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Alburnus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Alburnus.unclassified_Alburnus;

/// <summary>
/// Abstract class for unclassified Alburnus (no rank).
/// NCBI TaxId: 2638763
/// </summary>
public abstract class unclassified_Alburnus : Alburnus, Iunclassified_Alburnus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Alburnus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638763;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Alburnus";
}
