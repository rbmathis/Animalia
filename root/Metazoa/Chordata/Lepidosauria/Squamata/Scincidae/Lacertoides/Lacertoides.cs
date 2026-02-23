using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Lacertoides;

/// <summary>
/// Abstract class for Lacertoides (genus).
/// NCBI TaxId: 394131
/// </summary>
public abstract class Lacertoides : Scincidae, ILacertoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lacertoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 394131;

    /// <inheritdoc />
    public virtual string GenusName => "Lacertoides";

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
