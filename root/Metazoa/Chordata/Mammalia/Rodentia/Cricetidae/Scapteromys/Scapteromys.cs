using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Scapteromys;

/// <summary>
/// Abstract class for Scapteromys (genus).
/// NCBI TaxId: 89125
/// </summary>
public abstract class Scapteromys : Cricetidae, IScapteromys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scapteromys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 89125;

    /// <inheritdoc />
    public virtual string GenusName => "Scapteromys";

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
