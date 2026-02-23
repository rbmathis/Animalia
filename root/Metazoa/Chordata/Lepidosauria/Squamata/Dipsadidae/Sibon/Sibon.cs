using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Sibon;

/// <summary>
/// Abstract class for Sibon (genus).
/// NCBI TaxId: 211650
/// </summary>
public abstract class Sibon : Dipsadidae, ISibon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sibon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 211650;

    /// <inheritdoc />
    public virtual string GenusName => "Sibon";

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
