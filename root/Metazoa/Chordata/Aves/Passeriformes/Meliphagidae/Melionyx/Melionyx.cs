using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Melionyx;

/// <summary>
/// Abstract class for Melionyx (genus).
/// NCBI TaxId: 2821872
/// </summary>
public abstract class Melionyx : Meliphagidae, IMelionyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melionyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2821872;

    /// <inheritdoc />
    public virtual string GenusName => "Melionyx";

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
