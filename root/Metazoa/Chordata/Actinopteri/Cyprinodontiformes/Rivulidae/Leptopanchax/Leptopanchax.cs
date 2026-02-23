using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Leptopanchax;

/// <summary>
/// Abstract class for Leptopanchax (genus).
/// NCBI TaxId: 3069384
/// </summary>
public abstract class Leptopanchax : Rivulidae, ILeptopanchax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptopanchax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3069384;

    /// <inheritdoc />
    public virtual string GenusName => "Leptopanchax";

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
