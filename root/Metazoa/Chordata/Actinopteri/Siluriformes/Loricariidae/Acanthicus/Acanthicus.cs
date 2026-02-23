using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Acanthicus;

/// <summary>
/// Abstract class for Acanthicus (genus).
/// NCBI TaxId: 337731
/// </summary>
public abstract class Acanthicus : Loricariidae, IAcanthicus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acanthicus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 337731;

    /// <inheritdoc />
    public virtual string GenusName => "Acanthicus";

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
