using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Pseudoloricaria;

/// <summary>
/// Abstract class for Pseudoloricaria (genus).
/// NCBI TaxId: 1642589
/// </summary>
public abstract class Pseudoloricaria : Loricariidae, IPseudoloricaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudoloricaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1642589;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudoloricaria";

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
