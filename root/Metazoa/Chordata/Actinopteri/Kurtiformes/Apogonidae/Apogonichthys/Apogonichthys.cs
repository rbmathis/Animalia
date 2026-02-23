using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Apogonichthys;

/// <summary>
/// Abstract class for Apogonichthys (genus).
/// NCBI TaxId: 1147078
/// </summary>
public abstract class Apogonichthys : Apogonidae, IApogonichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Apogonichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1147078;

    /// <inheritdoc />
    public virtual string GenusName => "Apogonichthys";

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
