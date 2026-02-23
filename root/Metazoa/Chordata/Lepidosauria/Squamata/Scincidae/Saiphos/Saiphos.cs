using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Saiphos;

/// <summary>
/// Abstract class for Saiphos (genus).
/// NCBI TaxId: 172941
/// </summary>
public abstract class Saiphos : Scincidae, ISaiphos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Saiphos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 172941;

    /// <inheritdoc />
    public virtual string GenusName => "Saiphos";

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
