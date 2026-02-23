using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Pseudalsophis;

/// <summary>
/// Abstract class for Pseudalsophis (genus).
/// NCBI TaxId: 1260349
/// </summary>
public abstract class Pseudalsophis : Dipsadidae, IPseudalsophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudalsophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1260349;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudalsophis";

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
