using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pilosa.Megalonychidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pilosa.Megalonychidae.Megalonyx;

/// <summary>
/// Abstract class for Megalonyx (genus).
/// NCBI TaxId: 2546667
/// </summary>
public abstract class Megalonyx : Megalonychidae, IMegalonyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Megalonyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2546667;

    /// <inheritdoc />
    public virtual string GenusName => "Megalonyx";

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
