using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Rhyneptesicus;

/// <summary>
/// Abstract class for Rhyneptesicus (genus).
/// NCBI TaxId: 3411094
/// </summary>
public abstract class Rhyneptesicus : Vespertilionidae, IRhyneptesicus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhyneptesicus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3411094;

    /// <inheritdoc />
    public virtual string GenusName => "Rhyneptesicus";

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
