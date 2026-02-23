using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Myomyscus;

/// <summary>
/// Abstract class for Myomyscus (genus).
/// NCBI TaxId: 485436
/// </summary>
public abstract class Myomyscus : Muridae, IMyomyscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myomyscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 485436;

    /// <inheritdoc />
    public virtual string GenusName => "Myomyscus";

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
