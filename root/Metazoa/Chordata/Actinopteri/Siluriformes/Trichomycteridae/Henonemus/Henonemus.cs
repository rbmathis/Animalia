using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Henonemus;

/// <summary>
/// Abstract class for Henonemus (genus).
/// NCBI TaxId: 238684
/// </summary>
public abstract class Henonemus : Trichomycteridae, IHenonemus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Henonemus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 238684;

    /// <inheritdoc />
    public virtual string GenusName => "Henonemus";

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
