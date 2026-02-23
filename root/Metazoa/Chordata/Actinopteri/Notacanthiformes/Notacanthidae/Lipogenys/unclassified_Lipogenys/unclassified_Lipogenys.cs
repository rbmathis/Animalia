using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Notacanthiformes.Notacanthidae.Lipogenys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Notacanthiformes.Notacanthidae.Lipogenys.unclassified_Lipogenys;

/// <summary>
/// Abstract class for unclassified Lipogenys (no rank).
/// NCBI TaxId: 3083375
/// </summary>
public abstract class unclassified_Lipogenys : Lipogenys, Iunclassified_Lipogenys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lipogenys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3083375;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lipogenys";
}
