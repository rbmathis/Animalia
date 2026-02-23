using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae.Aluterus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae.Aluterus.unclassified_Aluterus;

/// <summary>
/// Abstract class for unclassified Aluterus (no rank).
/// NCBI TaxId: 3444673
/// </summary>
public abstract class unclassified_Aluterus : Aluterus, Iunclassified_Aluterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Aluterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3444673;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Aluterus";
}
