using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Nemipteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Nemipteridae.Scolopsis;

/// <summary>
/// Abstract class for Scolopsis (genus).
/// NCBI TaxId: 119745
/// </summary>
public abstract class Scolopsis : Nemipteridae, IScolopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scolopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 119745;

    /// <inheritdoc />
    public virtual string GenusName => "Scolopsis";

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
