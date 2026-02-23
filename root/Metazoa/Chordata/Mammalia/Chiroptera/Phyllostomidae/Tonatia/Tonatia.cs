using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Tonatia;

/// <summary>
/// Abstract class for Tonatia (genus).
/// NCBI TaxId: 9425
/// </summary>
public abstract class Tonatia : Phyllostomidae, ITonatia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tonatia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9425;

    /// <inheritdoc />
    public virtual string GenusName => "Tonatia";

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
