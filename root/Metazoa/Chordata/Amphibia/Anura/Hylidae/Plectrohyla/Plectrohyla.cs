using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Plectrohyla;

/// <summary>
/// Abstract class for Plectrohyla (genus).
/// NCBI TaxId: 317384
/// </summary>
public abstract class Plectrohyla : Hylidae, IPlectrohyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Plectrohyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 317384;

    /// <inheritdoc />
    public virtual string GenusName => "Plectrohyla";

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
