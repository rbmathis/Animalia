using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Malaconotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Malaconotidae.Chlorophoneus;

/// <summary>
/// Abstract class for Chlorophoneus (genus).
/// NCBI TaxId: 488404
/// </summary>
public abstract class Chlorophoneus : Malaconotidae, IChlorophoneus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chlorophoneus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 488404;

    /// <inheritdoc />
    public virtual string GenusName => "Chlorophoneus";

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
