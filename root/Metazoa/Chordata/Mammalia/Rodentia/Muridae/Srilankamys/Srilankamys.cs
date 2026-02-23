using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Srilankamys;

/// <summary>
/// Abstract class for Srilankamys (genus).
/// NCBI TaxId: 1036332
/// </summary>
public abstract class Srilankamys : Muridae, ISrilankamys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Srilankamys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1036332;

    /// <inheritdoc />
    public virtual string GenusName => "Srilankamys";

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
