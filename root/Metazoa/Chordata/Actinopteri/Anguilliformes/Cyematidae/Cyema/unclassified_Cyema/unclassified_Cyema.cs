using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Cyematidae.Cyema;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Cyematidae.Cyema.unclassified_Cyema;

/// <summary>
/// Abstract class for unclassified Cyema (no rank).
/// NCBI TaxId: 2633927
/// </summary>
public abstract class unclassified_Cyema : Cyema, Iunclassified_Cyema
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cyema";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633927;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cyema";
}
