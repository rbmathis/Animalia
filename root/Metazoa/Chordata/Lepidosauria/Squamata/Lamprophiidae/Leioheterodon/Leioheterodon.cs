using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Leioheterodon;

/// <summary>
/// Abstract class for Leioheterodon (genus).
/// NCBI TaxId: 46576
/// </summary>
public abstract class Leioheterodon : Lamprophiidae, ILeioheterodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leioheterodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 46576;

    /// <inheritdoc />
    public virtual string GenusName => "Leioheterodon";

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
