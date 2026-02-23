using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pilosa.Myrmecophagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pilosa.Myrmecophagidae.Tamandua;

/// <summary>
/// Abstract class for Tamandua (genus).
/// NCBI TaxId: 9350
/// </summary>
public abstract class Tamandua : Myrmecophagidae, ITamandua
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tamandua";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9350;

    /// <inheritdoc />
    public virtual string GenusName => "Tamandua";

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
