using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Tridensimilis;

/// <summary>
/// Abstract class for Tridensimilis (genus).
/// NCBI TaxId: 2050945
/// </summary>
public abstract class Tridensimilis : Trichomycteridae, ITridensimilis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tridensimilis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2050945;

    /// <inheritdoc />
    public virtual string GenusName => "Tridensimilis";

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
