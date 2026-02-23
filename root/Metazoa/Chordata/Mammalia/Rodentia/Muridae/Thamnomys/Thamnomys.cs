using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Thamnomys;

/// <summary>
/// Abstract class for Thamnomys (genus).
/// NCBI TaxId: 408720
/// </summary>
public abstract class Thamnomys : Muridae, IThamnomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thamnomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 408720;

    /// <inheritdoc />
    public virtual string GenusName => "Thamnomys";

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
