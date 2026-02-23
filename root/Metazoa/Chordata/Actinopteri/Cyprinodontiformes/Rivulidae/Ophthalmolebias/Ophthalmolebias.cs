using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Ophthalmolebias;

/// <summary>
/// Abstract class for Ophthalmolebias (genus).
/// NCBI TaxId: 941674
/// </summary>
public abstract class Ophthalmolebias : Rivulidae, IOphthalmolebias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ophthalmolebias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 941674;

    /// <inheritdoc />
    public virtual string GenusName => "Ophthalmolebias";

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
