using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae.Xenophallus;

/// <summary>
/// Abstract class for Xenophallus (genus).
/// NCBI TaxId: 585983
/// </summary>
public abstract class Xenophallus : Poeciliidae, IXenophallus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenophallus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 585983;

    /// <inheritdoc />
    public virtual string GenusName => "Xenophallus";

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
