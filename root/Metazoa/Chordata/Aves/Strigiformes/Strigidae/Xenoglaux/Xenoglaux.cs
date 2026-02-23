using AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Xenoglaux;

/// <summary>
/// Abstract class for Xenoglaux (genus).
/// NCBI TaxId: 2653991
/// </summary>
public abstract class Xenoglaux : Strigidae, IXenoglaux
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenoglaux";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2653991;

    /// <inheritdoc />
    public virtual string GenusName => "Xenoglaux";

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
