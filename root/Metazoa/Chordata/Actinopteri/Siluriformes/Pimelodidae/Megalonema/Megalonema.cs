using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.Megalonema;

/// <summary>
/// Abstract class for Megalonema (genus).
/// NCBI TaxId: 1150232
/// </summary>
public abstract class Megalonema : Pimelodidae, IMegalonema
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Megalonema";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1150232;

    /// <inheritdoc />
    public virtual string GenusName => "Megalonema";

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
