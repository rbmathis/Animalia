using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Marmorosphax;

/// <summary>
/// Abstract class for Marmorosphax (genus).
/// NCBI TaxId: 394141
/// </summary>
public abstract class Marmorosphax : Scincidae, IMarmorosphax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Marmorosphax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 394141;

    /// <inheritdoc />
    public virtual string GenusName => "Marmorosphax";

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
