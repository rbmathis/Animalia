using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Uranomys;

/// <summary>
/// Abstract class for Uranomys (genus).
/// NCBI TaxId: 41271
/// </summary>
public abstract class Uranomys : Muridae, IUranomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Uranomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 41271;

    /// <inheritdoc />
    public virtual string GenusName => "Uranomys";

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
