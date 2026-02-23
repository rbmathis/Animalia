using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Procatopodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Procatopodidae.Micropanchax;

/// <summary>
/// Abstract class for Micropanchax (genus).
/// NCBI TaxId: 1573793
/// </summary>
public abstract class Micropanchax : Procatopodidae, IMicropanchax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Micropanchax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1573793;

    /// <inheritdoc />
    public virtual string GenusName => "Micropanchax";

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
