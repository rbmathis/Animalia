using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Stenocephalemys;

/// <summary>
/// Abstract class for Stenocephalemys (genus).
/// NCBI TaxId: 89456
/// </summary>
public abstract class Stenocephalemys : Muridae, IStenocephalemys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stenocephalemys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 89456;

    /// <inheritdoc />
    public virtual string GenusName => "Stenocephalemys";

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
