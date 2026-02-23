using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Kunsia;

/// <summary>
/// Abstract class for Kunsia (genus).
/// NCBI TaxId: 89120
/// </summary>
public abstract class Kunsia : Cricetidae, IKunsia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kunsia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 89120;

    /// <inheritdoc />
    public virtual string GenusName => "Kunsia";

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
