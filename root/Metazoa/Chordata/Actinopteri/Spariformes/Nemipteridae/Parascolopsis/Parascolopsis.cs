using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Nemipteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Nemipteridae.Parascolopsis;

/// <summary>
/// Abstract class for Parascolopsis (genus).
/// NCBI TaxId: 490340
/// </summary>
public abstract class Parascolopsis : Nemipteridae, IParascolopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parascolopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 490340;

    /// <inheritdoc />
    public virtual string GenusName => "Parascolopsis";

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
