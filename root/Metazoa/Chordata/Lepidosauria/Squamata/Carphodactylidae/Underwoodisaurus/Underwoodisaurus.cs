using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Carphodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Carphodactylidae.Underwoodisaurus;

/// <summary>
/// Abstract class for Underwoodisaurus (genus).
/// NCBI TaxId: 567528
/// </summary>
public abstract class Underwoodisaurus : Carphodactylidae, IUnderwoodisaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Underwoodisaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 567528;

    /// <inheritdoc />
    public virtual string GenusName => "Underwoodisaurus";

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
