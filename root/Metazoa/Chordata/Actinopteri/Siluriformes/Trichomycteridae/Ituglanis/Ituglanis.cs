using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Ituglanis;

/// <summary>
/// Abstract class for Ituglanis (genus).
/// NCBI TaxId: 1349273
/// </summary>
public abstract class Ituglanis : Trichomycteridae, IItuglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ituglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1349273;

    /// <inheritdoc />
    public virtual string GenusName => "Ituglanis";

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
