using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Conilurus;

/// <summary>
/// Abstract class for Conilurus (genus).
/// NCBI TaxId: 10126
/// </summary>
public abstract class Conilurus : Muridae, IConilurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Conilurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 10126;

    /// <inheritdoc />
    public virtual string GenusName => "Conilurus";

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
