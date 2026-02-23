using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Microcambeva;

/// <summary>
/// Abstract class for Microcambeva (genus).
/// NCBI TaxId: 2563391
/// </summary>
public abstract class Microcambeva : Trichomycteridae, IMicrocambeva
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microcambeva";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2563391;

    /// <inheritdoc />
    public virtual string GenusName => "Microcambeva";

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
