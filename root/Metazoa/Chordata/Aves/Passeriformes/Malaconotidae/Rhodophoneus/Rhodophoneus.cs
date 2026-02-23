using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Malaconotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Malaconotidae.Rhodophoneus;

/// <summary>
/// Abstract class for Rhodophoneus (genus).
/// NCBI TaxId: 272901
/// </summary>
public abstract class Rhodophoneus : Malaconotidae, IRhodophoneus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhodophoneus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 272901;

    /// <inheritdoc />
    public virtual string GenusName => "Rhodophoneus";

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
