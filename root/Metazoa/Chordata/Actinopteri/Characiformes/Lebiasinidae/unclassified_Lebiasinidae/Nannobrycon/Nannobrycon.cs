using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Lebiasinidae.unclassified_Lebiasinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Lebiasinidae.unclassified_Lebiasinidae.Nannobrycon;

/// <summary>
/// Abstract class for Nannobrycon (genus).
/// NCBI TaxId: 42511
/// </summary>
public abstract class Nannobrycon : unclassified_Lebiasinidae, INannobrycon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nannobrycon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42511;

    /// <inheritdoc />
    public virtual string GenusName => "Nannobrycon";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
