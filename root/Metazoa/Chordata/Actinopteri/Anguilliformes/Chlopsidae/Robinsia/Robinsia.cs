using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Chlopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Chlopsidae.Robinsia;

/// <summary>
/// Abstract class for Robinsia (genus).
/// NCBI TaxId: 118148
/// </summary>
public abstract class Robinsia : Chlopsidae, IRobinsia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Robinsia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 118148;

    /// <inheritdoc />
    public virtual string GenusName => "Robinsia";

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
