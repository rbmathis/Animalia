using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae.Haemulopsis;

/// <summary>
/// Abstract class for Haemulopsis (genus).
/// NCBI TaxId: 1010787
/// </summary>
public abstract class Haemulopsis : Haemulidae, IHaemulopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Haemulopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1010787;

    /// <inheritdoc />
    public virtual string GenusName => "Haemulopsis";

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
