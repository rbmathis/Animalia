using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Percopsiformes.Amblyopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Percopsiformes.Amblyopsidae.Chologaster;

/// <summary>
/// Abstract class for Chologaster (genus).
/// NCBI TaxId: 390311
/// </summary>
public abstract class Chologaster : Amblyopsidae, IChologaster
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chologaster";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 390311;

    /// <inheritdoc />
    public virtual string GenusName => "Chologaster";

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
