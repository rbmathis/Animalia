using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Tarsiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Tarsiidae.Cephalopachus;

/// <summary>
/// Abstract class for Cephalopachus (genus).
/// NCBI TaxId: 1971489
/// </summary>
public abstract class Cephalopachus : Tarsiidae, ICephalopachus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cephalopachus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1971489;

    /// <inheritdoc />
    public virtual string GenusName => "Cephalopachus";

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
