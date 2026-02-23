using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae.Xenodexia;

/// <summary>
/// Abstract class for Xenodexia (genus).
/// NCBI TaxId: 417475
/// </summary>
public abstract class Xenodexia : Poeciliidae, IXenodexia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenodexia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 417475;

    /// <inheritdoc />
    public virtual string GenusName => "Xenodexia";

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
