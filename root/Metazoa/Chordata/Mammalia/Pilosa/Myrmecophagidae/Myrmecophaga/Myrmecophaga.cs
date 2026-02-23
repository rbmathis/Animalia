using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pilosa.Myrmecophagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pilosa.Myrmecophagidae.Myrmecophaga;

/// <summary>
/// Abstract class for Myrmecophaga (genus).
/// NCBI TaxId: 71005
/// </summary>
public abstract class Myrmecophaga : Myrmecophagidae, IMyrmecophaga
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myrmecophaga";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 71005;

    /// <inheritdoc />
    public virtual string GenusName => "Myrmecophaga";

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
