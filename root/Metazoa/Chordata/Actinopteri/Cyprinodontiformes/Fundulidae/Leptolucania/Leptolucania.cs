using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Fundulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Fundulidae.Leptolucania;

/// <summary>
/// Abstract class for Leptolucania (genus).
/// NCBI TaxId: 1046122
/// </summary>
public abstract class Leptolucania : Fundulidae, ILeptolucania
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptolucania";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1046122;

    /// <inheritdoc />
    public virtual string GenusName => "Leptolucania";

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
