using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Thalasseleotrididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Thalasseleotrididae.Tempestichthys;

/// <summary>
/// Abstract class for Tempestichthys (genus).
/// NCBI TaxId: 3034719
/// </summary>
public abstract class Tempestichthys : Thalasseleotrididae, ITempestichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tempestichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3034719;

    /// <inheritdoc />
    public virtual string GenusName => "Tempestichthys";

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
