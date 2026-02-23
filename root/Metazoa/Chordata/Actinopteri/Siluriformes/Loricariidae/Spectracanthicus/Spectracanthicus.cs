using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Spectracanthicus;

/// <summary>
/// Abstract class for Spectracanthicus (genus).
/// NCBI TaxId: 1633196
/// </summary>
public abstract class Spectracanthicus : Loricariidae, ISpectracanthicus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Spectracanthicus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1633196;

    /// <inheritdoc />
    public virtual string GenusName => "Spectracanthicus";

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
