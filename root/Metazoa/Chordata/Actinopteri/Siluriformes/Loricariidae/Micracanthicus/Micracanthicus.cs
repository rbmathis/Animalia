using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Micracanthicus;

/// <summary>
/// Abstract class for Micracanthicus (genus).
/// NCBI TaxId: 1633140
/// </summary>
public abstract class Micracanthicus : Loricariidae, IMicracanthicus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Micracanthicus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1633140;

    /// <inheritdoc />
    public virtual string GenusName => "Micracanthicus";

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
