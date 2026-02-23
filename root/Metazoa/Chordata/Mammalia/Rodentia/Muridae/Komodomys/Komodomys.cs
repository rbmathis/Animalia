using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Komodomys;

/// <summary>
/// Abstract class for Komodomys (genus).
/// NCBI TaxId: 1799707
/// </summary>
public abstract class Komodomys : Muridae, IKomodomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Komodomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1799707;

    /// <inheritdoc />
    public virtual string GenusName => "Komodomys";

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
