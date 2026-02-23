using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Pholidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Pholidae.Apodichthys;

/// <summary>
/// Abstract class for Apodichthys (genus).
/// NCBI TaxId: 57778
/// </summary>
public abstract class Apodichthys : Pholidae, IApodichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Apodichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57778;

    /// <inheritdoc />
    public virtual string GenusName => "Apodichthys";

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
