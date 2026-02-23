using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Anablepsoides;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Anablepsoides.unclassified_Anablepsoides;

/// <summary>
/// Abstract class for unclassified Anablepsoides (no rank).
/// NCBI TaxId: 2930382
/// </summary>
public abstract class unclassified_Anablepsoides : Anablepsoides, Iunclassified_Anablepsoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Anablepsoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2930382;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Anablepsoides";
}
