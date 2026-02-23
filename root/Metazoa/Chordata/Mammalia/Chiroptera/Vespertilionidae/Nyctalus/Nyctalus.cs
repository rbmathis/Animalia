using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Nyctalus;

/// <summary>
/// Abstract class for Nyctalus (genus).
/// NCBI TaxId: 51299
/// </summary>
public abstract class Nyctalus : Vespertilionidae, INyctalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nyctalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 51299;

    /// <inheritdoc />
    public virtual string GenusName => "Nyctalus";

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
