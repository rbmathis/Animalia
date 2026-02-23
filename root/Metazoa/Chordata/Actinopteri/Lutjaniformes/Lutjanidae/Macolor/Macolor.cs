using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae.Macolor;

/// <summary>
/// Abstract class for Macolor (genus).
/// NCBI TaxId: 396790
/// </summary>
public abstract class Macolor : Lutjanidae, IMacolor
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Macolor";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 396790;

    /// <inheritdoc />
    public virtual string GenusName => "Macolor";

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
