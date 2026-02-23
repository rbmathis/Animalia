using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Ondatra;

/// <summary>
/// Abstract class for Ondatra (genus).
/// NCBI TaxId: 10059
/// </summary>
public abstract class Ondatra : Cricetidae, IOndatra
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ondatra";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 10059;

    /// <inheritdoc />
    public virtual string GenusName => "Ondatra";

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
