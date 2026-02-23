using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Tonkinomys;

/// <summary>
/// Abstract class for Tonkinomys (genus).
/// NCBI TaxId: 1305944
/// </summary>
public abstract class Tonkinomys : Muridae, ITonkinomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tonkinomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1305944;

    /// <inheritdoc />
    public virtual string GenusName => "Tonkinomys";

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
