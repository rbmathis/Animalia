using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Trigonectes;

/// <summary>
/// Abstract class for Trigonectes (genus).
/// NCBI TaxId: 52673
/// </summary>
public abstract class Trigonectes : Rivulidae, ITrigonectes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trigonectes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52673;

    /// <inheritdoc />
    public virtual string GenusName => "Trigonectes";

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
