using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Hadropogonichthys;

/// <summary>
/// Abstract class for Hadropogonichthys (genus).
/// NCBI TaxId: 2768305
/// </summary>
public abstract class Hadropogonichthys : Zoarcidae, IHadropogonichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hadropogonichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2768305;

    /// <inheritdoc />
    public virtual string GenusName => "Hadropogonichthys";

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
