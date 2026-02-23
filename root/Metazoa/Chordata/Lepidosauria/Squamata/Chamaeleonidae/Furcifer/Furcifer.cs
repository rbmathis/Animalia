using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Chamaeleonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Chamaeleonidae.Furcifer;

/// <summary>
/// Abstract class for Furcifer (genus).
/// NCBI TaxId: 143472
/// </summary>
public abstract class Furcifer : Chamaeleonidae, IFurcifer
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Furcifer";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143472;

    /// <inheritdoc />
    public virtual string GenusName => "Furcifer";

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
