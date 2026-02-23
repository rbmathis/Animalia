using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Lamottemys;

/// <summary>
/// Abstract class for Lamottemys (genus).
/// NCBI TaxId: 1261105
/// </summary>
public abstract class Lamottemys : Muridae, ILamottemys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lamottemys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1261105;

    /// <inheritdoc />
    public virtual string GenusName => "Lamottemys";

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
