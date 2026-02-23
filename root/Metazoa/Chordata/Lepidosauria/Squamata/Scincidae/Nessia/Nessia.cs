using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Nessia;

/// <summary>
/// Abstract class for Nessia (genus).
/// NCBI TaxId: 1545038
/// </summary>
public abstract class Nessia : Scincidae, INessia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nessia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1545038;

    /// <inheritdoc />
    public virtual string GenusName => "Nessia";

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
