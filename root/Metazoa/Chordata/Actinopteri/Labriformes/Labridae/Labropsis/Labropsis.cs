using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Labropsis;

/// <summary>
/// Abstract class for Labropsis (genus).
/// NCBI TaxId: 241311
/// </summary>
public abstract class Labropsis : Labridae, ILabropsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Labropsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241311;

    /// <inheritdoc />
    public virtual string GenusName => "Labropsis";

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
