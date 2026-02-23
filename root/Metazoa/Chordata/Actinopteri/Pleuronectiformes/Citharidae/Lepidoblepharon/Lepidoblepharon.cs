using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Citharidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Citharidae.Lepidoblepharon;

/// <summary>
/// Abstract class for Lepidoblepharon (genus).
/// NCBI TaxId: 195620
/// </summary>
public abstract class Lepidoblepharon : Citharidae, ILepidoblepharon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lepidoblepharon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 195620;

    /// <inheritdoc />
    public virtual string GenusName => "Lepidoblepharon";

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
