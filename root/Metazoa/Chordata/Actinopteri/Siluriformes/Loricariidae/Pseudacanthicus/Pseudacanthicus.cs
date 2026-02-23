using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Pseudacanthicus;

/// <summary>
/// Abstract class for Pseudacanthicus (genus).
/// NCBI TaxId: 52094
/// </summary>
public abstract class Pseudacanthicus : Loricariidae, IPseudacanthicus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudacanthicus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52094;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudacanthicus";

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
