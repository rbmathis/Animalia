using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Subdoluseps;

/// <summary>
/// Abstract class for Subdoluseps (genus).
/// NCBI TaxId: 2571093
/// </summary>
public abstract class Subdoluseps : Scincidae, ISubdoluseps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Subdoluseps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2571093;

    /// <inheritdoc />
    public virtual string GenusName => "Subdoluseps";

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
