using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae.Pao;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae.Pao.unclassified_Pao;

/// <summary>
/// Abstract class for unclassified Pao (no rank).
/// NCBI TaxId: 2774204
/// </summary>
public abstract class unclassified_Pao : Pao, Iunclassified_Pao
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pao";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2774204;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pao";
}
