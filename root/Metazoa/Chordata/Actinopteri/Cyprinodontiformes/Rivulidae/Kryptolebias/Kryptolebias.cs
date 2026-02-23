using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Kryptolebias;

/// <summary>
/// Abstract class for Kryptolebias (genus).
/// NCBI TaxId: 326431
/// </summary>
public abstract class Kryptolebias : Rivulidae, IKryptolebias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kryptolebias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 326431;

    /// <inheritdoc />
    public virtual string GenusName => "Kryptolebias";

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
