using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae.Scaptonyx;

/// <summary>
/// Abstract class for Scaptonyx (genus).
/// NCBI TaxId: 224954
/// </summary>
public abstract class Scaptonyx : Talpidae, IScaptonyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scaptonyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 224954;

    /// <inheritdoc />
    public virtual string GenusName => "Scaptonyx";

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
