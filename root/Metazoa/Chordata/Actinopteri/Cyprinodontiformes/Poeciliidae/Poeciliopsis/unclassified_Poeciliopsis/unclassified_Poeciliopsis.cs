using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae.Poeciliopsis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae.Poeciliopsis.unclassified_Poeciliopsis;

/// <summary>
/// Abstract class for unclassified Poeciliopsis (no rank).
/// NCBI TaxId: 2622221
/// </summary>
public abstract class unclassified_Poeciliopsis : Poeciliopsis, Iunclassified_Poeciliopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Poeciliopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622221;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Poeciliopsis";
}
