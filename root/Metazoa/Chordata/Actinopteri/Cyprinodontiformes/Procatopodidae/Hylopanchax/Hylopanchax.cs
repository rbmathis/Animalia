using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Procatopodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Procatopodidae.Hylopanchax;

/// <summary>
/// Abstract class for Hylopanchax (genus).
/// NCBI TaxId: 2546134
/// </summary>
public abstract class Hylopanchax : Procatopodidae, IHylopanchax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hylopanchax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2546134;

    /// <inheritdoc />
    public virtual string GenusName => "Hylopanchax";

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
