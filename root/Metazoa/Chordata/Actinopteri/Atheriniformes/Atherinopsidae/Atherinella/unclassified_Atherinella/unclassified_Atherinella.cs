using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinopsidae.Atherinella;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinopsidae.Atherinella.unclassified_Atherinella;

/// <summary>
/// Abstract class for unclassified Atherinella (no rank).
/// NCBI TaxId: 2624411
/// </summary>
public abstract class unclassified_Atherinella : Atherinella, Iunclassified_Atherinella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Atherinella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624411;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Atherinella";
}
