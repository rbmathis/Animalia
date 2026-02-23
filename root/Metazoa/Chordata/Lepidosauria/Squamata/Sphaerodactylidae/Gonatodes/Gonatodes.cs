using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Sphaerodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Sphaerodactylidae.Gonatodes;

/// <summary>
/// Abstract class for Gonatodes (genus).
/// NCBI TaxId: 71165
/// </summary>
public abstract class Gonatodes : Sphaerodactylidae, IGonatodes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gonatodes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 71165;

    /// <inheritdoc />
    public virtual string GenusName => "Gonatodes";

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
