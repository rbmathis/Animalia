using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Iluocoetes;

/// <summary>
/// Abstract class for Iluocoetes (genus).
/// NCBI TaxId: 458578
/// </summary>
public abstract class Iluocoetes : Zoarcidae, IIluocoetes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Iluocoetes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 458578;

    /// <inheritdoc />
    public virtual string GenusName => "Iluocoetes";

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
