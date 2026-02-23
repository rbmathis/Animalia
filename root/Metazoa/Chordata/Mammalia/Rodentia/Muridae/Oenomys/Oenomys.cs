using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Oenomys;

/// <summary>
/// Abstract class for Oenomys (genus).
/// NCBI TaxId: 332667
/// </summary>
public abstract class Oenomys : Muridae, IOenomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oenomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 332667;

    /// <inheritdoc />
    public virtual string GenusName => "Oenomys";

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
