using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.unclassified_Argentiniformes;

/// <summary>
/// Abstract class for unclassified Argentiniformes (no rank).
/// NCBI TaxId: 3411931
/// </summary>
public abstract class unclassified_Argentiniformes : Argentiniformes, Iunclassified_Argentiniformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Argentiniformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3411931;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Argentiniformes";
}
