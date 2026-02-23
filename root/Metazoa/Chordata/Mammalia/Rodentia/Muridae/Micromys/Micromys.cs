using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Micromys;

/// <summary>
/// Abstract class for Micromys (genus).
/// NCBI TaxId: 13150
/// </summary>
public abstract class Micromys : Muridae, IMicromys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Micromys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 13150;

    /// <inheritdoc />
    public virtual string GenusName => "Micromys";

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
