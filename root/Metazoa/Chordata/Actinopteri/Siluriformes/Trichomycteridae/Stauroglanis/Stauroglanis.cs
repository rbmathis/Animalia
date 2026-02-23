using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Stauroglanis;

/// <summary>
/// Abstract class for Stauroglanis (genus).
/// NCBI TaxId: 2023060
/// </summary>
public abstract class Stauroglanis : Trichomycteridae, IStauroglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stauroglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2023060;

    /// <inheritdoc />
    public virtual string GenusName => "Stauroglanis";

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
