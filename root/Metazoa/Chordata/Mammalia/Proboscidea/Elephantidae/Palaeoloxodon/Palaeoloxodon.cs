using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Proboscidea.Elephantidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Proboscidea.Elephantidae.Palaeoloxodon;

/// <summary>
/// Abstract class for Palaeoloxodon (genus).
/// NCBI TaxId: 3064004
/// </summary>
public abstract class Palaeoloxodon : Elephantidae, IPalaeoloxodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Palaeoloxodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3064004;

    /// <inheritdoc />
    public virtual string GenusName => "Palaeoloxodon";

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
