using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Zyzomys;

/// <summary>
/// Abstract class for Zyzomys (genus).
/// NCBI TaxId: 337229
/// </summary>
public abstract class Zyzomys : Muridae, IZyzomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zyzomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 337229;

    /// <inheritdoc />
    public virtual string GenusName => "Zyzomys";

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
