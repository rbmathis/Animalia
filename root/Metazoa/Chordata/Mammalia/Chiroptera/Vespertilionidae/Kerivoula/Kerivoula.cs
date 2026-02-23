using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Kerivoula;

/// <summary>
/// Abstract class for Kerivoula (genus).
/// NCBI TaxId: 59454
/// </summary>
public abstract class Kerivoula : Vespertilionidae, IKerivoula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kerivoula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 59454;

    /// <inheritdoc />
    public virtual string GenusName => "Kerivoula";

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
