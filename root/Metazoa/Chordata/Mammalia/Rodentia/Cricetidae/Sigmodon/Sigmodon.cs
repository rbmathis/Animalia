using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Sigmodon;

/// <summary>
/// Abstract class for Sigmodon (genus).
/// NCBI TaxId: 42414
/// </summary>
public abstract class Sigmodon : Cricetidae, ISigmodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sigmodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42414;

    /// <inheritdoc />
    public virtual string GenusName => "Sigmodon";

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
