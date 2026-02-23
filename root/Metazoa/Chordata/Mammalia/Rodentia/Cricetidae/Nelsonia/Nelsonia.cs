using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Nelsonia;

/// <summary>
/// Abstract class for Nelsonia (genus).
/// NCBI TaxId: 56224
/// </summary>
public abstract class Nelsonia : Cricetidae, INelsonia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nelsonia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56224;

    /// <inheritdoc />
    public virtual string GenusName => "Nelsonia";

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
