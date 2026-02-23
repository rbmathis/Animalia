using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Glaphyropoma;

/// <summary>
/// Abstract class for Glaphyropoma (genus).
/// NCBI TaxId: 2023058
/// </summary>
public abstract class Glaphyropoma : Trichomycteridae, IGlaphyropoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Glaphyropoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2023058;

    /// <inheritdoc />
    public virtual string GenusName => "Glaphyropoma";

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
