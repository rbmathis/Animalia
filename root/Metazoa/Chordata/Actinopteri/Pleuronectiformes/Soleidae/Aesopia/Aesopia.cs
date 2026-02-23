using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae.Aesopia;

/// <summary>
/// Abstract class for Aesopia (genus).
/// NCBI TaxId: 215405
/// </summary>
public abstract class Aesopia : Soleidae, IAesopia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aesopia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 215405;

    /// <inheritdoc />
    public virtual string GenusName => "Aesopia";

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
