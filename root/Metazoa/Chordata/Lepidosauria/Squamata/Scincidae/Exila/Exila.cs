using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Exila;

/// <summary>
/// Abstract class for Exila (genus).
/// NCBI TaxId: 1331794
/// </summary>
public abstract class Exila : Scincidae, IExila
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Exila";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1331794;

    /// <inheritdoc />
    public virtual string GenusName => "Exila";

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
