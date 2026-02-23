using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Anablepsoides;

/// <summary>
/// Abstract class for Anablepsoides (genus).
/// NCBI TaxId: 1254594
/// </summary>
public abstract class Anablepsoides : Rivulidae, IAnablepsoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anablepsoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1254594;

    /// <inheritdoc />
    public virtual string GenusName => "Anablepsoides";

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
