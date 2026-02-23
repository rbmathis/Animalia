using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Cassistrellus;

/// <summary>
/// Abstract class for Cassistrellus (genus).
/// NCBI TaxId: 2069572
/// </summary>
public abstract class Cassistrellus : Vespertilionidae, ICassistrellus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cassistrellus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2069572;

    /// <inheritdoc />
    public virtual string GenusName => "Cassistrellus";

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
