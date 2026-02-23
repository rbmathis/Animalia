using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Pelomys;

/// <summary>
/// Abstract class for Pelomys (genus).
/// NCBI TaxId: 121574
/// </summary>
public abstract class Pelomys : Muridae, IPelomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pelomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 121574;

    /// <inheritdoc />
    public virtual string GenusName => "Pelomys";

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
