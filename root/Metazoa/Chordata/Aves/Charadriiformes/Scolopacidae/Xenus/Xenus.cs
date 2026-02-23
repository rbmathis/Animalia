using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae.Xenus;

/// <summary>
/// Abstract class for Xenus (genus).
/// NCBI TaxId: 171276
/// </summary>
public abstract class Xenus : Scolopacidae, IXenus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 171276;

    /// <inheritdoc />
    public virtual string GenusName => "Xenus";

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
