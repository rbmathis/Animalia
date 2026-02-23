using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Citharidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Citharidae.Citharoides;

/// <summary>
/// Abstract class for Citharoides (genus).
/// NCBI TaxId: 195601
/// </summary>
public abstract class Citharoides : Citharidae, ICitharoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Citharoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 195601;

    /// <inheritdoc />
    public virtual string GenusName => "Citharoides";

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
