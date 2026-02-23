using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Ectrepopterus;

/// <summary>
/// Abstract class for Ectrepopterus (genus).
/// NCBI TaxId: 2608191
/// </summary>
public abstract class Ectrepopterus : Acestrorhamphidae, IEctrepopterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ectrepopterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2608191;

    /// <inheritdoc />
    public virtual string GenusName => "Ectrepopterus";

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
