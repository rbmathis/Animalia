using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Tropidophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Tropidophiidae.Ungaliophis;

/// <summary>
/// Abstract class for Ungaliophis (genus).
/// NCBI TaxId: 51847
/// </summary>
public abstract class Ungaliophis : Tropidophiidae, IUngaliophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ungaliophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 51847;

    /// <inheritdoc />
    public virtual string GenusName => "Ungaliophis";

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
