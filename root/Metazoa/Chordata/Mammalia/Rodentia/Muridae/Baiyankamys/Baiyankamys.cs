using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Baiyankamys;

/// <summary>
/// Abstract class for Baiyankamys (genus).
/// NCBI TaxId: 2716775
/// </summary>
public abstract class Baiyankamys : Muridae, IBaiyankamys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Baiyankamys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2716775;

    /// <inheritdoc />
    public virtual string GenusName => "Baiyankamys";

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
