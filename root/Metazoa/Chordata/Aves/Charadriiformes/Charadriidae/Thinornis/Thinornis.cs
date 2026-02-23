using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Charadriidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Charadriidae.Thinornis;

/// <summary>
/// Abstract class for Thinornis (genus).
/// NCBI TaxId: 50409
/// </summary>
public abstract class Thinornis : Charadriidae, IThinornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thinornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 50409;

    /// <inheritdoc />
    public virtual string GenusName => "Thinornis";

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
