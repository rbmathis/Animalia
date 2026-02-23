using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pellorneidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pellorneidae.Pellorneum;

/// <summary>
/// Abstract class for Pellorneum (genus).
/// NCBI TaxId: 98145
/// </summary>
public abstract class Pellorneum : Pellorneidae, IPellorneum
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pellorneum";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 98145;

    /// <inheritdoc />
    public virtual string GenusName => "Pellorneum";

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
