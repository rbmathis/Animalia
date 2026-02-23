using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vangidae.Xenopirostris;

/// <summary>
/// Abstract class for Xenopirostris (genus).
/// NCBI TaxId: 125314
/// </summary>
public abstract class Xenopirostris : Vangidae, IXenopirostris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenopirostris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 125314;

    /// <inheritdoc />
    public virtual string GenusName => "Xenopirostris";

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
