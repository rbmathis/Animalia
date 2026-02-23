using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae.Etelis;

/// <summary>
/// Abstract class for Etelis (genus).
/// NCBI TaxId: 40508
/// </summary>
public abstract class Etelis : Lutjanidae, IEtelis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Etelis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 40508;

    /// <inheritdoc />
    public virtual string GenusName => "Etelis";

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
