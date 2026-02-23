using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinidae.unclassified_Atherininae;

/// <summary>
/// Abstract class for unclassified Atherininae (no rank).
/// NCBI TaxId: 2859045
/// </summary>
public abstract class unclassified_Atherininae : Atherinidae, Iunclassified_Atherininae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Atherininae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2859045;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Atherininae";
}
