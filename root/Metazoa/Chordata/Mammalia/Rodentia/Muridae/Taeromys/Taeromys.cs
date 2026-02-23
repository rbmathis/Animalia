using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Taeromys;

/// <summary>
/// Abstract class for Taeromys (genus).
/// NCBI TaxId: 1405179
/// </summary>
public abstract class Taeromys : Muridae, ITaeromys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Taeromys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1405179;

    /// <inheritdoc />
    public virtual string GenusName => "Taeromys";

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
