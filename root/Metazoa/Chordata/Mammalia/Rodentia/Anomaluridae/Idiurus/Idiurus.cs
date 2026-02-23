using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Anomaluridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Anomaluridae.Idiurus;

/// <summary>
/// Abstract class for Idiurus (genus).
/// NCBI TaxId: 101666
/// </summary>
public abstract class Idiurus : Anomaluridae, IIdiurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Idiurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 101666;

    /// <inheritdoc />
    public virtual string GenusName => "Idiurus";

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
