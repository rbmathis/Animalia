using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Dolichonyx;

/// <summary>
/// Abstract class for Dolichonyx (genus).
/// NCBI TaxId: 84798
/// </summary>
public abstract class Dolichonyx : Icteridae, IDolichonyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dolichonyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 84798;

    /// <inheritdoc />
    public virtual string GenusName => "Dolichonyx";

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
