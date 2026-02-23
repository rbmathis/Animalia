using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Submyotodon;

/// <summary>
/// Abstract class for Submyotodon (genus).
/// NCBI TaxId: 1636536
/// </summary>
public abstract class Submyotodon : Vespertilionidae, ISubmyotodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Submyotodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1636536;

    /// <inheritdoc />
    public virtual string GenusName => "Submyotodon";

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
