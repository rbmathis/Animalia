using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Tyttobrycon;

/// <summary>
/// Abstract class for Tyttobrycon (genus).
/// NCBI TaxId: 2608205
/// </summary>
public abstract class Tyttobrycon : Acestrorhamphidae, ITyttobrycon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tyttobrycon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2608205;

    /// <inheritdoc />
    public virtual string GenusName => "Tyttobrycon";

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
