using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhynchidae.Acestrorhynchus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhynchidae.Acestrorhynchus.unclassified_Acestrorhynchus;

/// <summary>
/// Abstract class for unclassified Acestrorhynchus (no rank).
/// NCBI TaxId: 2641696
/// </summary>
public abstract class unclassified_Acestrorhynchus : Acestrorhynchus, Iunclassified_Acestrorhynchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Acestrorhynchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641696;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Acestrorhynchus";
}
