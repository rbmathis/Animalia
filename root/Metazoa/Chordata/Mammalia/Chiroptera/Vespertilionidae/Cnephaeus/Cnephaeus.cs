using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Cnephaeus;

/// <summary>
/// Abstract class for Cnephaeus (genus).
/// NCBI TaxId: 29077
/// </summary>
public abstract class Cnephaeus : Vespertilionidae, ICnephaeus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cnephaeus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 29077;

    /// <inheritdoc />
    public virtual string GenusName => "Cnephaeus";

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
