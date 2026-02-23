using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Uromys;

/// <summary>
/// Abstract class for Uromys (genus).
/// NCBI TaxId: 36798
/// </summary>
public abstract class Uromys : Muridae, IUromys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Uromys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36798;

    /// <inheritdoc />
    public virtual string GenusName => "Uromys";

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
