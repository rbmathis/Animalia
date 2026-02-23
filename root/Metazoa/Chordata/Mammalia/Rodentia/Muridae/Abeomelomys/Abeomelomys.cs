using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Abeomelomys;

/// <summary>
/// Abstract class for Abeomelomys (genus).
/// NCBI TaxId: 491869
/// </summary>
public abstract class Abeomelomys : Muridae, IAbeomelomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Abeomelomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 491869;

    /// <inheritdoc />
    public virtual string GenusName => "Abeomelomys";

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
