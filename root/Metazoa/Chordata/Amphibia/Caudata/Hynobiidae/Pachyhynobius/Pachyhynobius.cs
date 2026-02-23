using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Hynobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Hynobiidae.Pachyhynobius;

/// <summary>
/// Abstract class for Pachyhynobius (genus).
/// NCBI TaxId: 288316
/// </summary>
public abstract class Pachyhynobius : Hynobiidae, IPachyhynobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pachyhynobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 288316;

    /// <inheritdoc />
    public virtual string GenusName => "Pachyhynobius";

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
