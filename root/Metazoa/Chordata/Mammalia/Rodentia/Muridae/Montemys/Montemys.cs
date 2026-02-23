using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Montemys;

/// <summary>
/// Abstract class for Montemys (genus).
/// NCBI TaxId: 3371079
/// </summary>
public abstract class Montemys : Muridae, IMontemys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Montemys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3371079;

    /// <inheritdoc />
    public virtual string GenusName => "Montemys";

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
