using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Paracheirodon;

/// <summary>
/// Abstract class for Paracheirodon (genus).
/// NCBI TaxId: 42491
/// </summary>
public abstract class Paracheirodon : Acestrorhamphidae, IParacheirodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paracheirodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42491;

    /// <inheritdoc />
    public virtual string GenusName => "Paracheirodon";

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
