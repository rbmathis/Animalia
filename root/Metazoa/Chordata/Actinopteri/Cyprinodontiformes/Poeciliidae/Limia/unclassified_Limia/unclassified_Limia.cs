using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae.Limia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae.Limia.unclassified_Limia;

/// <summary>
/// Abstract class for unclassified Limia (no rank).
/// NCBI TaxId: 2635747
/// </summary>
public abstract class unclassified_Limia : Limia, Iunclassified_Limia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Limia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2635747;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Limia";
}
