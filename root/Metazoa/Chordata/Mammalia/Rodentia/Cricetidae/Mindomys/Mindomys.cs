using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Mindomys;

/// <summary>
/// Abstract class for Mindomys (genus).
/// NCBI TaxId: 1003859
/// </summary>
public abstract class Mindomys : Cricetidae, IMindomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mindomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1003859;

    /// <inheritdoc />
    public virtual string GenusName => "Mindomys";

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
