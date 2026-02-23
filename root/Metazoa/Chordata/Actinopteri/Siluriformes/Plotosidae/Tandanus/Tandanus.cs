using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Plotosidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Plotosidae.Tandanus;

/// <summary>
/// Abstract class for Tandanus (genus).
/// NCBI TaxId: 490727
/// </summary>
public abstract class Tandanus : Plotosidae, ITandanus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tandanus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 490727;

    /// <inheritdoc />
    public virtual string GenusName => "Tandanus";

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
