using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Jupiaba;

/// <summary>
/// Abstract class for Jupiaba (genus).
/// NCBI TaxId: 681920
/// </summary>
public abstract class Jupiaba : Acestrorhamphidae, IJupiaba
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Jupiaba";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 681920;

    /// <inheritdoc />
    public virtual string GenusName => "Jupiaba";

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
