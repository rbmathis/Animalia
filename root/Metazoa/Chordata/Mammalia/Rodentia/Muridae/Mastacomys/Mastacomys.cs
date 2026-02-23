using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Mastacomys;

/// <summary>
/// Abstract class for Mastacomys (genus).
/// NCBI TaxId: 337223
/// </summary>
public abstract class Mastacomys : Muridae, IMastacomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mastacomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 337223;

    /// <inheritdoc />
    public virtual string GenusName => "Mastacomys";

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
