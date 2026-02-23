using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Merlucciidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Merlucciidae.Macruronus;

/// <summary>
/// Abstract class for Macruronus (genus).
/// NCBI TaxId: 92049
/// </summary>
public abstract class Macruronus : Merlucciidae, IMacruronus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Macruronus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 92049;

    /// <inheritdoc />
    public virtual string GenusName => "Macruronus";

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
