using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae.Xerotyphlops;

/// <summary>
/// Abstract class for Xerotyphlops (genus).
/// NCBI TaxId: 1498637
/// </summary>
public abstract class Xerotyphlops : Typhlopidae, IXerotyphlops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xerotyphlops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1498637;

    /// <inheritdoc />
    public virtual string GenusName => "Xerotyphlops";

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
