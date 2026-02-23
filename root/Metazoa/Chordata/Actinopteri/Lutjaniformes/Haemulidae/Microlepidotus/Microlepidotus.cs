using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae.Microlepidotus;

/// <summary>
/// Abstract class for Microlepidotus (genus).
/// NCBI TaxId: 875788
/// </summary>
public abstract class Microlepidotus : Haemulidae, IMicrolepidotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microlepidotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 875788;

    /// <inheritdoc />
    public virtual string GenusName => "Microlepidotus";

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
