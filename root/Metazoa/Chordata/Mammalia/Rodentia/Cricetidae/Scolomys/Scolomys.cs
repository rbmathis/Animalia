using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Scolomys;

/// <summary>
/// Abstract class for Scolomys (genus).
/// NCBI TaxId: 48016
/// </summary>
public abstract class Scolomys : Cricetidae, IScolomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scolomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 48016;

    /// <inheritdoc />
    public virtual string GenusName => "Scolomys";

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
