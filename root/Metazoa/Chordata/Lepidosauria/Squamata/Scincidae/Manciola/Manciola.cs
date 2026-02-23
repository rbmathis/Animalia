using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Manciola;

/// <summary>
/// Abstract class for Manciola (genus).
/// NCBI TaxId: 1332314
/// </summary>
public abstract class Manciola : Scincidae, IManciola
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Manciola";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1332314;

    /// <inheritdoc />
    public virtual string GenusName => "Manciola";

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
