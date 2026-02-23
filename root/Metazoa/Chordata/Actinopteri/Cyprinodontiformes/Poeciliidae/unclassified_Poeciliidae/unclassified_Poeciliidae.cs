using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae.unclassified_Poeciliidae;

/// <summary>
/// Abstract class for unclassified Poeciliidae (no rank).
/// NCBI TaxId: 1402211
/// </summary>
public abstract class unclassified_Poeciliidae : Poeciliidae, Iunclassified_Poeciliidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Poeciliidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1402211;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Poeciliidae";
}
