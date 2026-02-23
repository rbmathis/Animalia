using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Lycodopsis;

/// <summary>
/// Abstract class for Lycodopsis (genus).
/// NCBI TaxId: 1772090
/// </summary>
public abstract class Lycodopsis : Zoarcidae, ILycodopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lycodopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1772090;

    /// <inheritdoc />
    public virtual string GenusName => "Lycodopsis";

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
