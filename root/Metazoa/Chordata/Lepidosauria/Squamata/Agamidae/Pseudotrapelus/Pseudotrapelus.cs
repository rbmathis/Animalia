using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Pseudotrapelus;

/// <summary>
/// Abstract class for Pseudotrapelus (genus).
/// NCBI TaxId: 118228
/// </summary>
public abstract class Pseudotrapelus : Agamidae, IPseudotrapelus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudotrapelus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 118228;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudotrapelus";

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
