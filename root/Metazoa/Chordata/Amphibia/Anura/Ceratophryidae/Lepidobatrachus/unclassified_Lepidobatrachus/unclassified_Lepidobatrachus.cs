using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ceratophryidae.Lepidobatrachus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ceratophryidae.Lepidobatrachus.unclassified_Lepidobatrachus;

/// <summary>
/// Abstract class for unclassified Lepidobatrachus (no rank).
/// NCBI TaxId: 2634733
/// </summary>
public abstract class unclassified_Lepidobatrachus : Lepidobatrachus, Iunclassified_Lepidobatrachus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lepidobatrachus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634733;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lepidobatrachus";
}
