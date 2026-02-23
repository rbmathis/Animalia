using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Latridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Latridae.Mendosoma;

/// <summary>
/// Abstract class for Mendosoma (genus).
/// NCBI TaxId: 97163
/// </summary>
public abstract class Mendosoma : Latridae, IMendosoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mendosoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 97163;

    /// <inheritdoc />
    public virtual string GenusName => "Mendosoma";

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
