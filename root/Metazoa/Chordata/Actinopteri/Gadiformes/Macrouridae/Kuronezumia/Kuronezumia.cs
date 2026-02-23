using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae.Kuronezumia;

/// <summary>
/// Abstract class for Kuronezumia (genus).
/// NCBI TaxId: 2485025
/// </summary>
public abstract class Kuronezumia : Macrouridae, IKuronezumia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kuronezumia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2485025;

    /// <inheritdoc />
    public virtual string GenusName => "Kuronezumia";

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
