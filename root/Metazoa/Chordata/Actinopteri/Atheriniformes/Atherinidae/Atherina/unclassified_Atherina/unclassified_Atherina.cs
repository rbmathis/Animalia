using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinidae.Atherina;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinidae.Atherina.unclassified_Atherina;

/// <summary>
/// Abstract class for unclassified Atherina (no rank).
/// NCBI TaxId: 2625343
/// </summary>
public abstract class unclassified_Atherina : Atherina, Iunclassified_Atherina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Atherina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625343;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Atherina";
}
