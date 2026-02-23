using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Miuroglanis;

/// <summary>
/// Abstract class for Miuroglanis (genus).
/// NCBI TaxId: 2050943
/// </summary>
public abstract class Miuroglanis : Trichomycteridae, IMiuroglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Miuroglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2050943;

    /// <inheritdoc />
    public virtual string GenusName => "Miuroglanis";

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
