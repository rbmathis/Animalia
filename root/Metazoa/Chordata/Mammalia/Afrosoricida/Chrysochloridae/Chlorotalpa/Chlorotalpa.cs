using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Afrosoricida.Chrysochloridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Afrosoricida.Chrysochloridae.Chlorotalpa;

/// <summary>
/// Abstract class for Chlorotalpa (genus).
/// NCBI TaxId: 745246
/// </summary>
public abstract class Chlorotalpa : Chrysochloridae, IChlorotalpa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chlorotalpa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 745246;

    /// <inheritdoc />
    public virtual string GenusName => "Chlorotalpa";

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
