using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae.Aprion;

/// <summary>
/// Abstract class for Aprion (genus).
/// NCBI TaxId: 396780
/// </summary>
public abstract class Aprion : Lutjanidae, IAprion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aprion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 396780;

    /// <inheritdoc />
    public virtual string GenusName => "Aprion";

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
