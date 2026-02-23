using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Macrophyllum;

/// <summary>
/// Abstract class for Macrophyllum (genus).
/// NCBI TaxId: 148055
/// </summary>
public abstract class Macrophyllum : Phyllostomidae, IMacrophyllum
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Macrophyllum";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 148055;

    /// <inheritdoc />
    public virtual string GenusName => "Macrophyllum";

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
