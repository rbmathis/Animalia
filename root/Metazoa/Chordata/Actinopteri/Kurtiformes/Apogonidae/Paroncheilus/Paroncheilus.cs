using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Paroncheilus;

/// <summary>
/// Abstract class for Paroncheilus (genus).
/// NCBI TaxId: 638291
/// </summary>
public abstract class Paroncheilus : Apogonidae, IParoncheilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paroncheilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 638291;

    /// <inheritdoc />
    public virtual string GenusName => "Paroncheilus";

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
