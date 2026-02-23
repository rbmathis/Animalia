using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes.unclassified_Zeiformes;

/// <summary>
/// Abstract class for unclassified Zeiformes (no rank).
/// NCBI TaxId: 727675
/// </summary>
public abstract class unclassified_Zeiformes : Zeiformes, Iunclassified_Zeiformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Zeiformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 727675;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Zeiformes";
}
