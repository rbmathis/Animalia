using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Carphodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Carphodactylidae.Uvidicolus;

/// <summary>
/// Abstract class for Uvidicolus (genus).
/// NCBI TaxId: 1208055
/// </summary>
public abstract class Uvidicolus : Carphodactylidae, IUvidicolus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Uvidicolus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1208055;

    /// <inheritdoc />
    public virtual string GenusName => "Uvidicolus";

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
