using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Mirostrellus;

/// <summary>
/// Abstract class for Mirostrellus (genus).
/// NCBI TaxId: 2741457
/// </summary>
public abstract class Mirostrellus : Vespertilionidae, IMirostrellus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mirostrellus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2741457;

    /// <inheritdoc />
    public virtual string GenusName => "Mirostrellus";

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
