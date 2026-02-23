using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Deomys;

/// <summary>
/// Abstract class for Deomys (genus).
/// NCBI TaxId: 106342
/// </summary>
public abstract class Deomys : Muridae, IDeomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Deomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 106342;

    /// <inheritdoc />
    public virtual string GenusName => "Deomys";

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
