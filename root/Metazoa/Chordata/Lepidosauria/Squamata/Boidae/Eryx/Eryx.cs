using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Boidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Boidae.Eryx;

/// <summary>
/// Abstract class for Eryx (genus).
/// NCBI TaxId: 51863
/// </summary>
public abstract class Eryx : Boidae, IEryx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eryx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 51863;

    /// <inheritdoc />
    public virtual string GenusName => "Eryx";

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
