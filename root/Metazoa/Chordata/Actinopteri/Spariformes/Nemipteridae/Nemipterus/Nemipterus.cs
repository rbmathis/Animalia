using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Nemipteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Nemipteridae.Nemipterus;

/// <summary>
/// Abstract class for Nemipterus (genus).
/// NCBI TaxId: 119724
/// </summary>
public abstract class Nemipterus : Nemipteridae, INemipterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nemipterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 119724;

    /// <inheritdoc />
    public virtual string GenusName => "Nemipterus";

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
