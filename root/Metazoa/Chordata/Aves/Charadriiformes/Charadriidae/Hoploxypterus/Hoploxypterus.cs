using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Charadriidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Charadriidae.Hoploxypterus;

/// <summary>
/// Abstract class for Hoploxypterus (genus).
/// NCBI TaxId: 3150784
/// </summary>
public abstract class Hoploxypterus : Charadriidae, IHoploxypterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hoploxypterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150784;

    /// <inheritdoc />
    public virtual string GenusName => "Hoploxypterus";

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
