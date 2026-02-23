using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Harpiola;

/// <summary>
/// Abstract class for Harpiola (genus).
/// NCBI TaxId: 685776
/// </summary>
public abstract class Harpiola : Vespertilionidae, IHarpiola
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Harpiola";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 685776;

    /// <inheritdoc />
    public virtual string GenusName => "Harpiola";

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
