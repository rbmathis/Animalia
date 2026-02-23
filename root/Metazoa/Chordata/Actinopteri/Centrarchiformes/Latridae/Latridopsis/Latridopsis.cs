using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Latridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Latridae.Latridopsis;

/// <summary>
/// Abstract class for Latridopsis (genus).
/// NCBI TaxId: 97159
/// </summary>
public abstract class Latridopsis : Latridae, ILatridopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Latridopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 97159;

    /// <inheritdoc />
    public virtual string GenusName => "Latridopsis";

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
