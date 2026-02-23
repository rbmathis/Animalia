using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Trichogenes;

/// <summary>
/// Abstract class for Trichogenes (genus).
/// NCBI TaxId: 585399
/// </summary>
public abstract class Trichogenes : Trichomycteridae, ITrichogenes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trichogenes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 585399;

    /// <inheritdoc />
    public virtual string GenusName => "Trichogenes";

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
