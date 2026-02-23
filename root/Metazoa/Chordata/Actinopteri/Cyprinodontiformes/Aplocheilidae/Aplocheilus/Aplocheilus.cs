using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Aplocheilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Aplocheilidae.Aplocheilus;

/// <summary>
/// Abstract class for Aplocheilus (genus).
/// NCBI TaxId: 52579
/// </summary>
public abstract class Aplocheilus : Aplocheilidae, IAplocheilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aplocheilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52579;

    /// <inheritdoc />
    public virtual string GenusName => "Aplocheilus";

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
