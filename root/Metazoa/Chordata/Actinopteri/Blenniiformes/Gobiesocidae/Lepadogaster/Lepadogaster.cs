using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Lepadogaster;

/// <summary>
/// Abstract class for Lepadogaster (genus).
/// NCBI TaxId: 164306
/// </summary>
public abstract class Lepadogaster : Gobiesocidae, ILepadogaster
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lepadogaster";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 164306;

    /// <inheritdoc />
    public virtual string GenusName => "Lepadogaster";

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
