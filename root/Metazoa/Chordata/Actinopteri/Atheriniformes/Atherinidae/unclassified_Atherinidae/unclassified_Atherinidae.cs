using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinidae.unclassified_Atherinidae;

/// <summary>
/// Abstract class for unclassified Atherinidae (no rank).
/// NCBI TaxId: 1182051
/// </summary>
public abstract class unclassified_Atherinidae : Atherinidae, Iunclassified_Atherinidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Atherinidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1182051;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Atherinidae";
}
