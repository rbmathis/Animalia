using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Carphodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Carphodactylidae.Orraya;

/// <summary>
/// Abstract class for Orraya (genus).
/// NCBI TaxId: 1208040
/// </summary>
public abstract class Orraya : Carphodactylidae, IOrraya
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Orraya";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1208040;

    /// <inheritdoc />
    public virtual string GenusName => "Orraya";

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
