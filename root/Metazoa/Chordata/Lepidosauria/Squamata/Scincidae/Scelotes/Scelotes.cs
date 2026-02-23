using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Scelotes;

/// <summary>
/// Abstract class for Scelotes (genus).
/// NCBI TaxId: 96431
/// </summary>
public abstract class Scelotes : Scincidae, IScelotes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scelotes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 96431;

    /// <inheritdoc />
    public virtual string GenusName => "Scelotes";

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
