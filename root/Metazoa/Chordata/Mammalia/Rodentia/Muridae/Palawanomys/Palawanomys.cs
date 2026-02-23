using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Palawanomys;

/// <summary>
/// Abstract class for Palawanomys (genus).
/// NCBI TaxId: 3002846
/// </summary>
public abstract class Palawanomys : Muridae, IPalawanomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Palawanomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3002846;

    /// <inheritdoc />
    public virtual string GenusName => "Palawanomys";

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
