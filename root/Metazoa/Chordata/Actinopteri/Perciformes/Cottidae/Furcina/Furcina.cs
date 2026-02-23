using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Furcina;

/// <summary>
/// Abstract class for Furcina (genus).
/// NCBI TaxId: 1526731
/// </summary>
public abstract class Furcina : Cottidae, IFurcina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Furcina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1526731;

    /// <inheritdoc />
    public virtual string GenusName => "Furcina";

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
