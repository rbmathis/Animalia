using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Uperodon;

/// <summary>
/// Abstract class for Uperodon (genus).
/// NCBI TaxId: 419663
/// </summary>
public abstract class Uperodon : Microhylidae, IUperodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Uperodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 419663;

    /// <inheritdoc />
    public virtual string GenusName => "Uperodon";

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
