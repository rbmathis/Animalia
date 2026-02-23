using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Pseudohemiodon;

/// <summary>
/// Abstract class for Pseudohemiodon (genus).
/// NCBI TaxId: 281770
/// </summary>
public abstract class Pseudohemiodon : Loricariidae, IPseudohemiodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudohemiodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 281770;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudohemiodon";

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
