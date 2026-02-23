using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Valenciidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Valenciidae.Valencia;

/// <summary>
/// Abstract class for Valencia (genus).
/// NCBI TaxId: 195854
/// </summary>
public abstract class Valencia : Valenciidae, IValencia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Valencia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 195854;

    /// <inheritdoc />
    public virtual string GenusName => "Valencia";

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
