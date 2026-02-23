using AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Uroglaux;

/// <summary>
/// Abstract class for Uroglaux (genus).
/// NCBI TaxId: 2653993
/// </summary>
public abstract class Uroglaux : Strigidae, IUroglaux
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Uroglaux";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2653993;

    /// <inheritdoc />
    public virtual string GenusName => "Uroglaux";

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
