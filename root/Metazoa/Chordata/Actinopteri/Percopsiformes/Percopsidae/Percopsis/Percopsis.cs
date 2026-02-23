using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Percopsiformes.Percopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Percopsiformes.Percopsidae.Percopsis;

/// <summary>
/// Abstract class for Percopsis (genus).
/// NCBI TaxId: 81380
/// </summary>
public abstract class Percopsis : Percopsidae, IPercopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Percopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 81380;

    /// <inheritdoc />
    public virtual string GenusName => "Percopsis";

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
