using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Praeteropus;

/// <summary>
/// Abstract class for Praeteropus (genus).
/// NCBI TaxId: 2923024
/// </summary>
public abstract class Praeteropus : Scincidae, IPraeteropus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Praeteropus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2923024;

    /// <inheritdoc />
    public virtual string GenusName => "Praeteropus";

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
