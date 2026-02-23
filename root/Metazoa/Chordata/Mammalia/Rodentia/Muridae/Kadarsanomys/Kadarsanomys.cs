using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Kadarsanomys;

/// <summary>
/// Abstract class for Kadarsanomys (genus).
/// NCBI TaxId: 2060319
/// </summary>
public abstract class Kadarsanomys : Muridae, IKadarsanomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kadarsanomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2060319;

    /// <inheritdoc />
    public virtual string GenusName => "Kadarsanomys";

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
