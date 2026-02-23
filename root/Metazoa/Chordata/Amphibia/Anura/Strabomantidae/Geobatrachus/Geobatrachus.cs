using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Strabomantidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Strabomantidae.Geobatrachus;

/// <summary>
/// Abstract class for Geobatrachus (genus).
/// NCBI TaxId: 613040
/// </summary>
public abstract class Geobatrachus : Strabomantidae, IGeobatrachus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Geobatrachus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 613040;

    /// <inheritdoc />
    public virtual string GenusName => "Geobatrachus";

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
