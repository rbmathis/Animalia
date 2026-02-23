using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Tarsiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Tarsiidae.Tarsius;

/// <summary>
/// Abstract class for Tarsius (genus).
/// NCBI TaxId: 9476
/// </summary>
public abstract class Tarsius : Tarsiidae, ITarsius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tarsius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9476;

    /// <inheritdoc />
    public virtual string GenusName => "Tarsius";

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
