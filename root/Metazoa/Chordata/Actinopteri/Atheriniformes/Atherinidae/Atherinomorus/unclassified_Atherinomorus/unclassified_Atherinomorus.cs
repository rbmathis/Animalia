using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinidae.Atherinomorus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinidae.Atherinomorus.unclassified_Atherinomorus;

/// <summary>
/// Abstract class for unclassified Atherinomorus (no rank).
/// NCBI TaxId: 2619644
/// </summary>
public abstract class unclassified_Atherinomorus : Atherinomorus, Iunclassified_Atherinomorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Atherinomorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619644;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Atherinomorus";
}
