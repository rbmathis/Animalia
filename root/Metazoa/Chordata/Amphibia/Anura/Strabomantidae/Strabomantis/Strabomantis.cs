using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Strabomantidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Strabomantidae.Strabomantis;

/// <summary>
/// Abstract class for Strabomantis (genus).
/// NCBI TaxId: 449231
/// </summary>
public abstract class Strabomantis : Strabomantidae, IStrabomantis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Strabomantis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 449231;

    /// <inheritdoc />
    public virtual string GenusName => "Strabomantis";

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
