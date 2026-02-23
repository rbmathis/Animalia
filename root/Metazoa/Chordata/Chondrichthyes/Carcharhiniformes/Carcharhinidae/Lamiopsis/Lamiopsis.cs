using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Carcharhinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Carcharhinidae.Lamiopsis;

/// <summary>
/// Abstract class for Lamiopsis (genus).
/// NCBI TaxId: 496091
/// </summary>
public abstract class Lamiopsis : Carcharhinidae, ILamiopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lamiopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 496091;

    /// <inheritdoc />
    public virtual string GenusName => "Lamiopsis";

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
