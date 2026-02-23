using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Scleronema;

/// <summary>
/// Abstract class for Scleronema (genus).
/// NCBI TaxId: 210582
/// </summary>
public abstract class Scleronema : Trichomycteridae, IScleronema
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scleronema";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 210582;

    /// <inheritdoc />
    public virtual string GenusName => "Scleronema";

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
