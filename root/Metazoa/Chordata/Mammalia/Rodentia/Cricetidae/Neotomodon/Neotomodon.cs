using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Neotomodon;

/// <summary>
/// Abstract class for Neotomodon (genus).
/// NCBI TaxId: 230080
/// </summary>
public abstract class Neotomodon : Cricetidae, INeotomodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neotomodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 230080;

    /// <inheritdoc />
    public virtual string GenusName => "Neotomodon";

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
