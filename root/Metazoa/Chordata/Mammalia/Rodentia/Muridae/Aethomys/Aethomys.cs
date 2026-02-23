using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Aethomys;

/// <summary>
/// Abstract class for Aethomys (genus).
/// NCBI TaxId: 61151
/// </summary>
public abstract class Aethomys : Muridae, IAethomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aethomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 61151;

    /// <inheritdoc />
    public virtual string GenusName => "Aethomys";

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
