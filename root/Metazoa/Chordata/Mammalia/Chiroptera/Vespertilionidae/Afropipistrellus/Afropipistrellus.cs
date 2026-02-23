using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Afropipistrellus;

/// <summary>
/// Abstract class for Afropipistrellus (genus).
/// NCBI TaxId: 3685292
/// </summary>
public abstract class Afropipistrellus : Vespertilionidae, IAfropipistrellus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Afropipistrellus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3685292;

    /// <inheritdoc />
    public virtual string GenusName => "Afropipistrellus";

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
