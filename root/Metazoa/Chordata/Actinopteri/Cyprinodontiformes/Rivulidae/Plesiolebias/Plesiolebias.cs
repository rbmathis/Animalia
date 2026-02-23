using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Plesiolebias;

/// <summary>
/// Abstract class for Plesiolebias (genus).
/// NCBI TaxId: 61830
/// </summary>
public abstract class Plesiolebias : Rivulidae, IPlesiolebias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Plesiolebias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 61830;

    /// <inheritdoc />
    public virtual string GenusName => "Plesiolebias";

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
