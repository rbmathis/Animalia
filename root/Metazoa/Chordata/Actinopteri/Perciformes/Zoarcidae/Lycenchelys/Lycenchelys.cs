using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Lycenchelys;

/// <summary>
/// Abstract class for Lycenchelys (genus).
/// NCBI TaxId: 215413
/// </summary>
public abstract class Lycenchelys : Zoarcidae, ILycenchelys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lycenchelys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 215413;

    /// <inheritdoc />
    public virtual string GenusName => "Lycenchelys";

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
