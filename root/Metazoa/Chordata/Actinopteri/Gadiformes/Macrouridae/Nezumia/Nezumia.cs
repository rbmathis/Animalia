using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae.Nezumia;

/// <summary>
/// Abstract class for Nezumia (genus).
/// NCBI TaxId: 303125
/// </summary>
public abstract class Nezumia : Macrouridae, INezumia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nezumia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 303125;

    /// <inheritdoc />
    public virtual string GenusName => "Nezumia";

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
