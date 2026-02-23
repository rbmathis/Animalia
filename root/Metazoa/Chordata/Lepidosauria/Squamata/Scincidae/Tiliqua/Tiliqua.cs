using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Tiliqua;

/// <summary>
/// Abstract class for Tiliqua (genus).
/// NCBI TaxId: 8526
/// </summary>
public abstract class Tiliqua : Scincidae, ITiliqua
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tiliqua";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8526;

    /// <inheritdoc />
    public virtual string GenusName => "Tiliqua";

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
