using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae.Rhomboplites;

/// <summary>
/// Abstract class for Rhomboplites (genus).
/// NCBI TaxId: 40506
/// </summary>
public abstract class Rhomboplites : Lutjanidae, IRhomboplites
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhomboplites";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 40506;

    /// <inheritdoc />
    public virtual string GenusName => "Rhomboplites";

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
