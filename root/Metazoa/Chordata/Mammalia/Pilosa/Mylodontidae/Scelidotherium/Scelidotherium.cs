using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pilosa.Mylodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pilosa.Mylodontidae.Scelidotherium;

/// <summary>
/// Abstract class for Scelidotherium (genus).
/// NCBI TaxId: 2546654
/// </summary>
public abstract class Scelidotherium : Mylodontidae, IScelidotherium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scelidotherium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2546654;

    /// <inheritdoc />
    public virtual string GenusName => "Scelidotherium";

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
