using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Pygidianops;

/// <summary>
/// Abstract class for Pygidianops (genus).
/// NCBI TaxId: 2563424
/// </summary>
public abstract class Pygidianops : Trichomycteridae, IPygidianops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pygidianops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2563424;

    /// <inheritdoc />
    public virtual string GenusName => "Pygidianops";

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
