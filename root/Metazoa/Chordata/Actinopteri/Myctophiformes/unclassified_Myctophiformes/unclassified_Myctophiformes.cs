using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.unclassified_Myctophiformes;

/// <summary>
/// Abstract class for unclassified Myctophiformes (no rank).
/// NCBI TaxId: 727486
/// </summary>
public abstract class unclassified_Myctophiformes : Myctophiformes, Iunclassified_Myctophiformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Myctophiformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 727486;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Myctophiformes";
}
