using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Puzanovia;

/// <summary>
/// Abstract class for Puzanovia (genus).
/// NCBI TaxId: 2893513
/// </summary>
public abstract class Puzanovia : Zoarcidae, IPuzanovia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Puzanovia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2893513;

    /// <inheritdoc />
    public virtual string GenusName => "Puzanovia";

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
