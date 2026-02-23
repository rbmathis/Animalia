using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Ithycyphus;

/// <summary>
/// Abstract class for Ithycyphus (genus).
/// NCBI TaxId: 224551
/// </summary>
public abstract class Ithycyphus : Lamprophiidae, IIthycyphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ithycyphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 224551;

    /// <inheritdoc />
    public virtual string GenusName => "Ithycyphus";

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
