using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Bullockia;

/// <summary>
/// Abstract class for Bullockia (genus).
/// NCBI TaxId: 390384
/// </summary>
public abstract class Bullockia : Trichomycteridae, IBullockia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bullockia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 390384;

    /// <inheritdoc />
    public virtual string GenusName => "Bullockia";

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
