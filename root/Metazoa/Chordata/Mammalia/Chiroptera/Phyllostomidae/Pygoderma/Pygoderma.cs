using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Pygoderma;

/// <summary>
/// Abstract class for Pygoderma (genus).
/// NCBI TaxId: 148028
/// </summary>
public abstract class Pygoderma : Phyllostomidae, IPygoderma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pygoderma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 148028;

    /// <inheritdoc />
    public virtual string GenusName => "Pygoderma";

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
