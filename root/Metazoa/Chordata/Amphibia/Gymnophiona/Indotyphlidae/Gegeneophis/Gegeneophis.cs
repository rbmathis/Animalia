using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Indotyphlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Indotyphlidae.Gegeneophis;

/// <summary>
/// Abstract class for Gegeneophis (genus).
/// NCBI TaxId: 194525
/// </summary>
public abstract class Gegeneophis : Indotyphlidae, IGegeneophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gegeneophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 194525;

    /// <inheritdoc />
    public virtual string GenusName => "Gegeneophis";

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
