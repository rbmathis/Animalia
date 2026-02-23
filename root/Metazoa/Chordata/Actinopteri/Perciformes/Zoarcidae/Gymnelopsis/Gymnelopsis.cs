using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Gymnelopsis;

/// <summary>
/// Abstract class for Gymnelopsis (genus).
/// NCBI TaxId: 470925
/// </summary>
public abstract class Gymnelopsis : Zoarcidae, IGymnelopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gymnelopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 470925;

    /// <inheritdoc />
    public virtual string GenusName => "Gymnelopsis";

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
