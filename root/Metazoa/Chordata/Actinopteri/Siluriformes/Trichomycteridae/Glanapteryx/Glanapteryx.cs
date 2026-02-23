using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Glanapteryx;

/// <summary>
/// Abstract class for Glanapteryx (genus).
/// NCBI TaxId: 3136083
/// </summary>
public abstract class Glanapteryx : Trichomycteridae, IGlanapteryx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Glanapteryx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3136083;

    /// <inheritdoc />
    public virtual string GenusName => "Glanapteryx";

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
