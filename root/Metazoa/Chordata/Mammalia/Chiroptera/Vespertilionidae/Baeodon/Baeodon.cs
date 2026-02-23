using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Baeodon;

/// <summary>
/// Abstract class for Baeodon (genus).
/// NCBI TaxId: 3072824
/// </summary>
public abstract class Baeodon : Vespertilionidae, IBaeodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Baeodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3072824;

    /// <inheritdoc />
    public virtual string GenusName => "Baeodon";

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
