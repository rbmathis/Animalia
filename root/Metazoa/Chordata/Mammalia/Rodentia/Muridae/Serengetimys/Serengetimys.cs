using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Serengetimys;

/// <summary>
/// Abstract class for Serengetimys (genus).
/// NCBI TaxId: 2912599
/// </summary>
public abstract class Serengetimys : Muridae, ISerengetimys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Serengetimys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2912599;

    /// <inheritdoc />
    public virtual string GenusName => "Serengetimys";

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
