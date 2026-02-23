using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae.Belonesox;

/// <summary>
/// Abstract class for Belonesox (genus).
/// NCBI TaxId: 37291
/// </summary>
public abstract class Belonesox : Poeciliidae, IBelonesox
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Belonesox";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 37291;

    /// <inheritdoc />
    public virtual string GenusName => "Belonesox";

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
