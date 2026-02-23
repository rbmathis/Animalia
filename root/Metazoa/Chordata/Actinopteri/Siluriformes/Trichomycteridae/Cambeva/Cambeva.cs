using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Cambeva;

/// <summary>
/// Abstract class for Cambeva (genus).
/// NCBI TaxId: 2491900
/// </summary>
public abstract class Cambeva : Trichomycteridae, ICambeva
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cambeva";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2491900;

    /// <inheritdoc />
    public virtual string GenusName => "Cambeva";

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
