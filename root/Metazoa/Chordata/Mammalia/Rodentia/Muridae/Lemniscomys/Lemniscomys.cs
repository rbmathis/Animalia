using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Lemniscomys;

/// <summary>
/// Abstract class for Lemniscomys (genus).
/// NCBI TaxId: 54110
/// </summary>
public abstract class Lemniscomys : Muridae, ILemniscomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lemniscomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 54110;

    /// <inheritdoc />
    public virtual string GenusName => "Lemniscomys";

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
