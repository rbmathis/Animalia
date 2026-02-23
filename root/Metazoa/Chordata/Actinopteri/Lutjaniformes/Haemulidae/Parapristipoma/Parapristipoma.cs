using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae.Parapristipoma;

/// <summary>
/// Abstract class for Parapristipoma (genus).
/// NCBI TaxId: 349639
/// </summary>
public abstract class Parapristipoma : Haemulidae, IParapristipoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parapristipoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 349639;

    /// <inheritdoc />
    public virtual string GenusName => "Parapristipoma";

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
