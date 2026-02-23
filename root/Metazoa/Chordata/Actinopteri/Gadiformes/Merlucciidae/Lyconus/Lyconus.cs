using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Merlucciidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Merlucciidae.Lyconus;

/// <summary>
/// Abstract class for Lyconus (genus).
/// NCBI TaxId: 473375
/// </summary>
public abstract class Lyconus : Merlucciidae, ILyconus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lyconus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 473375;

    /// <inheritdoc />
    public virtual string GenusName => "Lyconus";

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
