using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Strabomantidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Strabomantidae.Lynchius;

/// <summary>
/// Abstract class for Lynchius (genus).
/// NCBI TaxId: 613041
/// </summary>
public abstract class Lynchius : Strabomantidae, ILynchius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lynchius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 613041;

    /// <inheritdoc />
    public virtual string GenusName => "Lynchius";

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
