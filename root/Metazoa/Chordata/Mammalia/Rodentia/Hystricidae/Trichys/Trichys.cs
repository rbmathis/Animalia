using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Hystricidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Hystricidae.Trichys;

/// <summary>
/// Abstract class for Trichys (genus).
/// NCBI TaxId: 73864
/// </summary>
public abstract class Trichys : Hystricidae, ITrichys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trichys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 73864;

    /// <inheritdoc />
    public virtual string GenusName => "Trichys";

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
