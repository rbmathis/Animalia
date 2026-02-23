using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae.Pseudonezumia;

/// <summary>
/// Abstract class for Pseudonezumia (genus).
/// NCBI TaxId: 473379
/// </summary>
public abstract class Pseudonezumia : Macrouridae, IPseudonezumia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudonezumia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 473379;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudonezumia";

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
