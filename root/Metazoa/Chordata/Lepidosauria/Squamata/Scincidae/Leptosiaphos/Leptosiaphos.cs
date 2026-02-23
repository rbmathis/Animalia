using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Leptosiaphos;

/// <summary>
/// Abstract class for Leptosiaphos (genus).
/// NCBI TaxId: 245628
/// </summary>
public abstract class Leptosiaphos : Scincidae, ILeptosiaphos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptosiaphos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 245628;

    /// <inheritdoc />
    public virtual string GenusName => "Leptosiaphos";

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
