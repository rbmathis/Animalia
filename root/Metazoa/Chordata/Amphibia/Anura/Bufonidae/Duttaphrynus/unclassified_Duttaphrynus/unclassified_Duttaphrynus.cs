using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Duttaphrynus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Duttaphrynus.unclassified_Duttaphrynus;

/// <summary>
/// Abstract class for unclassified Duttaphrynus (no rank).
/// NCBI TaxId: 2639695
/// </summary>
public abstract class unclassified_Duttaphrynus : Duttaphrynus, Iunclassified_Duttaphrynus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Duttaphrynus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639695;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Duttaphrynus";
}
