using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Acanthopoma;

/// <summary>
/// Abstract class for Acanthopoma (genus).
/// NCBI TaxId: 648126
/// </summary>
public abstract class Acanthopoma : Trichomycteridae, IAcanthopoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acanthopoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 648126;

    /// <inheritdoc />
    public virtual string GenusName => "Acanthopoma";

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
