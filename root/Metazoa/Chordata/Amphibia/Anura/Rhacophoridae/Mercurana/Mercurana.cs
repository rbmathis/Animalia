using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Mercurana;

/// <summary>
/// Abstract class for Mercurana (genus).
/// NCBI TaxId: 1323771
/// </summary>
public abstract class Mercurana : Rhacophoridae, IMercurana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mercurana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1323771;

    /// <inheritdoc />
    public virtual string GenusName => "Mercurana";

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
