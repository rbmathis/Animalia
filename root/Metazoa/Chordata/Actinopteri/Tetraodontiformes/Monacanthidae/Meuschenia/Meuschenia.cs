using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae.Meuschenia;

/// <summary>
/// Abstract class for Meuschenia (genus).
/// NCBI TaxId: 303721
/// </summary>
public abstract class Meuschenia : Monacanthidae, IMeuschenia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Meuschenia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 303721;

    /// <inheritdoc />
    public virtual string GenusName => "Meuschenia";

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
