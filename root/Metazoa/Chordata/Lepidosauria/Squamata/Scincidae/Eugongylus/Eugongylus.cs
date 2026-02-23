using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Eugongylus;

/// <summary>
/// Abstract class for Eugongylus (genus).
/// NCBI TaxId: 99192
/// </summary>
public abstract class Eugongylus : Scincidae, IEugongylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eugongylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 99192;

    /// <inheritdoc />
    public virtual string GenusName => "Eugongylus";

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
