using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Strabomantidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Strabomantidae.Niceforonia;

/// <summary>
/// Abstract class for Niceforonia (genus).
/// NCBI TaxId: 613042
/// </summary>
public abstract class Niceforonia : Strabomantidae, INiceforonia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Niceforonia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 613042;

    /// <inheritdoc />
    public virtual string GenusName => "Niceforonia";

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
