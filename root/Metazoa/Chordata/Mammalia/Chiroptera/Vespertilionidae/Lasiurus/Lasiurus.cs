using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Lasiurus;

/// <summary>
/// Abstract class for Lasiurus (genus).
/// NCBI TaxId: 72130
/// </summary>
public abstract class Lasiurus : Vespertilionidae, ILasiurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lasiurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 72130;

    /// <inheritdoc />
    public virtual string GenusName => "Lasiurus";

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
