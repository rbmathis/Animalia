using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae.Parachelon;

/// <summary>
/// Abstract class for Parachelon (genus).
/// NCBI TaxId: 1935921
/// </summary>
public abstract class Parachelon : Mugilidae, IParachelon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parachelon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1935921;

    /// <inheritdoc />
    public virtual string GenusName => "Parachelon";

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
