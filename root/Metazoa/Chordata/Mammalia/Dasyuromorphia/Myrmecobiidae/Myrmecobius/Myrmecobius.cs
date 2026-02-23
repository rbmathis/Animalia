using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Myrmecobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Myrmecobiidae.Myrmecobius;

/// <summary>
/// Abstract class for Myrmecobius (genus).
/// NCBI TaxId: 55781
/// </summary>
public abstract class Myrmecobius : Myrmecobiidae, IMyrmecobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myrmecobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 55781;

    /// <inheritdoc />
    public virtual string GenusName => "Myrmecobius";

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
