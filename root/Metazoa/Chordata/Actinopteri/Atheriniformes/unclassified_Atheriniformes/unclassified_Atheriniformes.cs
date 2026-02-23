using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.unclassified_Atheriniformes;

/// <summary>
/// Abstract class for unclassified Atheriniformes (no rank).
/// NCBI TaxId: 723958
/// </summary>
public abstract class unclassified_Atheriniformes : Atheriniformes, Iunclassified_Atheriniformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Atheriniformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 723958;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Atheriniformes";
}
