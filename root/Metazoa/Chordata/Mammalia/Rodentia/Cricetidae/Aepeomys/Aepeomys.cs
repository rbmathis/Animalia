using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Aepeomys;

/// <summary>
/// Abstract class for Aepeomys (genus).
/// NCBI TaxId: 329887
/// </summary>
public abstract class Aepeomys : Cricetidae, IAepeomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aepeomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 329887;

    /// <inheritdoc />
    public virtual string GenusName => "Aepeomys";

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
