using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenidae.Gymnothorax;

/// <summary>
/// Abstract class for Gymnothorax (genus).
/// NCBI TaxId: 121281
/// </summary>
public abstract class Gymnothorax : Muraenidae, IGymnothorax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gymnothorax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 121281;

    /// <inheritdoc />
    public virtual string GenusName => "Gymnothorax";

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
