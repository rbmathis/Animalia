using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae.Xiphophorus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae.Xiphophorus.unclassified_Xiphophorus;

/// <summary>
/// Abstract class for unclassified Xiphophorus (no rank).
/// NCBI TaxId: 2622425
/// </summary>
public abstract class unclassified_Xiphophorus : Xiphophorus, Iunclassified_Xiphophorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Xiphophorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622425;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Xiphophorus";
}
