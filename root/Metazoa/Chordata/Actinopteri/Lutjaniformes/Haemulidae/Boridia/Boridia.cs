using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae.Boridia;

/// <summary>
/// Abstract class for Boridia (genus).
/// NCBI TaxId: 1010783
/// </summary>
public abstract class Boridia : Haemulidae, IBoridia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Boridia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1010783;

    /// <inheritdoc />
    public virtual string GenusName => "Boridia";

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
