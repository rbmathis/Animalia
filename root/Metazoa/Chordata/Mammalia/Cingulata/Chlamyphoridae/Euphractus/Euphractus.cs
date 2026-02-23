using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Cingulata.Chlamyphoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Cingulata.Chlamyphoridae.Euphractus;

/// <summary>
/// Abstract class for Euphractus (genus).
/// NCBI TaxId: 143299
/// </summary>
public abstract class Euphractus : Chlamyphoridae, IEuphractus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Euphractus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143299;

    /// <inheritdoc />
    public virtual string GenusName => "Euphractus";

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
