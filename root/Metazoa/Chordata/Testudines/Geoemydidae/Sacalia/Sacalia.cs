using AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Sacalia;

/// <summary>
/// Abstract class for Sacalia (genus).
/// NCBI TaxId: 74933
/// </summary>
public abstract class Sacalia : Geoemydidae, ISacalia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sacalia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 74933;

    /// <inheritdoc />
    public virtual string GenusName => "Sacalia";

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
