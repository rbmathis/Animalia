using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae.Temnocora;

/// <summary>
/// Abstract class for Temnocora (genus).
/// NCBI TaxId: 1696919
/// </summary>
public abstract class Temnocora : Liparidae, ITemnocora
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Temnocora";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1696919;

    /// <inheritdoc />
    public virtual string GenusName => "Temnocora";

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
