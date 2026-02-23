using AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Geoemyda;

/// <summary>
/// Abstract class for Geoemyda (genus).
/// NCBI TaxId: 204959
/// </summary>
public abstract class Geoemyda : Geoemydidae, IGeoemyda
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Geoemyda";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 204959;

    /// <inheritdoc />
    public virtual string GenusName => "Geoemyda";

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
