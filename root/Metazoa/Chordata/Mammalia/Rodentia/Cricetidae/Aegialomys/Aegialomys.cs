using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Aegialomys;

/// <summary>
/// Abstract class for Aegialomys (genus).
/// NCBI TaxId: 478561
/// </summary>
public abstract class Aegialomys : Cricetidae, IAegialomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aegialomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 478561;

    /// <inheritdoc />
    public virtual string GenusName => "Aegialomys";

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
