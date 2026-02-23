using AnimalKingdom.root.Metazoa.Chordata.Actinopteri;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.unclassified_Teleostei;

/// <summary>
/// Abstract class for unclassified Teleostei (no rank).
/// NCBI TaxId: 70861
/// </summary>
public abstract class unclassified_Teleostei : Actinopteri, Iunclassified_Teleostei
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Teleostei";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 70861;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Teleostei";
}
