using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Rivulus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Rivulus.unclassified_Rivulus;

/// <summary>
/// Abstract class for unclassified Rivulus (no rank).
/// NCBI TaxId: 2648773
/// </summary>
public abstract class unclassified_Rivulus : Rivulus, Iunclassified_Rivulus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rivulus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648773;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rivulus";
}
