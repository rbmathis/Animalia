using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Chingawaemys;

/// <summary>
/// Abstract class for Chingawaemys (genus).
/// NCBI TaxId: 2954918
/// </summary>
public abstract class Chingawaemys : Muridae, IChingawaemys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chingawaemys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2954918;

    /// <inheritdoc />
    public virtual string GenusName => "Chingawaemys";

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
