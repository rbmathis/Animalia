using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Jacanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Jacanidae.Hydrophasianus;

/// <summary>
/// Abstract class for Hydrophasianus (genus).
/// NCBI TaxId: 118784
/// </summary>
public abstract class Hydrophasianus : Jacanidae, IHydrophasianus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hydrophasianus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 118784;

    /// <inheritdoc />
    public virtual string GenusName => "Hydrophasianus";

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
