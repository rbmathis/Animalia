using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Alipiopsitta;

/// <summary>
/// Abstract class for Alipiopsitta (genus).
/// NCBI TaxId: 1548929
/// </summary>
public abstract class Alipiopsitta : Psittacidae, IAlipiopsitta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alipiopsitta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1548929;

    /// <inheritdoc />
    public virtual string GenusName => "Alipiopsitta";

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
