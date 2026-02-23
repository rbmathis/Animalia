using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Sigaloseps;

/// <summary>
/// Abstract class for Sigaloseps (genus).
/// NCBI TaxId: 394170
/// </summary>
public abstract class Sigaloseps : Scincidae, ISigaloseps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sigaloseps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 394170;

    /// <inheritdoc />
    public virtual string GenusName => "Sigaloseps";

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
