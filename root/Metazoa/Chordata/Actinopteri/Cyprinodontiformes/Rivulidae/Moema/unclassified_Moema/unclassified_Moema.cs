using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Moema;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Moema.unclassified_Moema;

/// <summary>
/// Abstract class for unclassified Moema (no rank).
/// NCBI TaxId: 2718421
/// </summary>
public abstract class unclassified_Moema : Moema, Iunclassified_Moema
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Moema";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2718421;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Moema";
}
