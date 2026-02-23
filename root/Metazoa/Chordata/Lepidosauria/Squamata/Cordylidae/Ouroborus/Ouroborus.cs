using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Cordylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Cordylidae.Ouroborus;

/// <summary>
/// Abstract class for Ouroborus (genus).
/// NCBI TaxId: 885516
/// </summary>
public abstract class Ouroborus : Cordylidae, IOuroborus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ouroborus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 885516;

    /// <inheritdoc />
    public virtual string GenusName => "Ouroborus";

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
