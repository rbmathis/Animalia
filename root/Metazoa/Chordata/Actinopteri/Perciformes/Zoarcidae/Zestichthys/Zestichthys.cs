using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Zestichthys;

/// <summary>
/// Abstract class for Zestichthys (genus).
/// NCBI TaxId: 2760775
/// </summary>
public abstract class Zestichthys : Zoarcidae, IZestichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zestichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2760775;

    /// <inheritdoc />
    public virtual string GenusName => "Zestichthys";

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
