using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Kyphosidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Kyphosidae.Tilodon;

/// <summary>
/// Abstract class for Tilodon (genus).
/// NCBI TaxId: 603450
/// </summary>
public abstract class Tilodon : Kyphosidae, ITilodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tilodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 603450;

    /// <inheritdoc />
    public virtual string GenusName => "Tilodon";

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
