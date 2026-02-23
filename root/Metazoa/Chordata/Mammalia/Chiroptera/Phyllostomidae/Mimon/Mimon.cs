using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Mimon;

/// <summary>
/// Abstract class for Mimon (genus).
/// NCBI TaxId: 148057
/// </summary>
public abstract class Mimon : Phyllostomidae, IMimon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mimon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 148057;

    /// <inheritdoc />
    public virtual string GenusName => "Mimon";

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
