using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Blarinomys;

/// <summary>
/// Abstract class for Blarinomys (genus).
/// NCBI TaxId: 89114
/// </summary>
public abstract class Blarinomys : Cricetidae, IBlarinomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Blarinomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 89114;

    /// <inheritdoc />
    public virtual string GenusName => "Blarinomys";

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
