using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Cricetulus;

/// <summary>
/// Abstract class for Cricetulus (genus).
/// NCBI TaxId: 10028
/// </summary>
public abstract class Cricetulus : Cricetidae, ICricetulus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cricetulus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 10028;

    /// <inheritdoc />
    public virtual string GenusName => "Cricetulus";

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
