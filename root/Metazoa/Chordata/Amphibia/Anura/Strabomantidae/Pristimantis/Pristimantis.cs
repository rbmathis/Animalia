using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Strabomantidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Strabomantidae.Pristimantis;

/// <summary>
/// Abstract class for Pristimantis (genus).
/// NCBI TaxId: 449102
/// </summary>
public abstract class Pristimantis : Strabomantidae, IPristimantis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pristimantis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 449102;

    /// <inheritdoc />
    public virtual string GenusName => "Pristimantis";

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
