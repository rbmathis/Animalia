using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Seleniolycus;

/// <summary>
/// Abstract class for Seleniolycus (genus).
/// NCBI TaxId: 1090489
/// </summary>
public abstract class Seleniolycus : Zoarcidae, ISeleniolycus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Seleniolycus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1090489;

    /// <inheritdoc />
    public virtual string GenusName => "Seleniolycus";

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
