using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae.Isacia;

/// <summary>
/// Abstract class for Isacia (genus).
/// NCBI TaxId: 1010791
/// </summary>
public abstract class Isacia : Haemulidae, IIsacia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Isacia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1010791;

    /// <inheritdoc />
    public virtual string GenusName => "Isacia";

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
