using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Sooretamys;

/// <summary>
/// Abstract class for Sooretamys (genus).
/// NCBI TaxId: 530179
/// </summary>
public abstract class Sooretamys : Cricetidae, ISooretamys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sooretamys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 530179;

    /// <inheritdoc />
    public virtual string GenusName => "Sooretamys";

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
