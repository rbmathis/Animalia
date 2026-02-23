using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Flexiseps;

/// <summary>
/// Abstract class for Flexiseps (genus).
/// NCBI TaxId: 2200833
/// </summary>
public abstract class Flexiseps : Scincidae, IFlexiseps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Flexiseps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2200833;

    /// <inheritdoc />
    public virtual string GenusName => "Flexiseps";

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
