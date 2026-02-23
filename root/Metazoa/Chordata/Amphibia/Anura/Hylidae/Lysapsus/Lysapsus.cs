using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Lysapsus;

/// <summary>
/// Abstract class for Lysapsus (genus).
/// NCBI TaxId: 2789017
/// </summary>
public abstract class Lysapsus : Hylidae, ILysapsus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lysapsus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2789017;

    /// <inheritdoc />
    public virtual string GenusName => "Lysapsus";

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
