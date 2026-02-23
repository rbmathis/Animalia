using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Mylomys;

/// <summary>
/// Abstract class for Mylomys (genus).
/// NCBI TaxId: 121580
/// </summary>
public abstract class Mylomys : Muridae, IMylomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mylomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 121580;

    /// <inheritdoc />
    public virtual string GenusName => "Mylomys";

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
