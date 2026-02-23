using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Cynopoecilus;

/// <summary>
/// Abstract class for Cynopoecilus (genus).
/// NCBI TaxId: 105040
/// </summary>
public abstract class Cynopoecilus : Rivulidae, ICynopoecilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cynopoecilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 105040;

    /// <inheritdoc />
    public virtual string GenusName => "Cynopoecilus";

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
