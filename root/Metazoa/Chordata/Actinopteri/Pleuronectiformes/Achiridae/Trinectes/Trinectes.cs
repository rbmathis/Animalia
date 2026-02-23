using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Achiridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Achiridae.Trinectes;

/// <summary>
/// Abstract class for Trinectes (genus).
/// NCBI TaxId: 195657
/// </summary>
public abstract class Trinectes : Achiridae, ITrinectes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trinectes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 195657;

    /// <inheritdoc />
    public virtual string GenusName => "Trinectes";

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
