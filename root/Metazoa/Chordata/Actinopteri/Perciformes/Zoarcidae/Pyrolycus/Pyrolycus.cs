using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Pyrolycus;

/// <summary>
/// Abstract class for Pyrolycus (genus).
/// NCBI TaxId: 2972963
/// </summary>
public abstract class Pyrolycus : Zoarcidae, IPyrolycus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pyrolycus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2972963;

    /// <inheritdoc />
    public virtual string GenusName => "Pyrolycus";

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
