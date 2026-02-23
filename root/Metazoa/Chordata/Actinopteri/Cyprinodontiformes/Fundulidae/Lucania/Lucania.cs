using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Fundulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Fundulidae.Lucania;

/// <summary>
/// Abstract class for Lucania (genus).
/// NCBI TaxId: 232976
/// </summary>
public abstract class Lucania : Fundulidae, ILucania
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lucania";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 232976;

    /// <inheritdoc />
    public virtual string GenusName => "Lucania";

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
