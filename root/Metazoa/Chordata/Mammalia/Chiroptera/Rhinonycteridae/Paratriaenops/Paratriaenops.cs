using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Rhinonycteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Rhinonycteridae.Paratriaenops;

/// <summary>
/// Abstract class for Paratriaenops (genus).
/// NCBI TaxId: 1615588
/// </summary>
public abstract class Paratriaenops : Rhinonycteridae, IParatriaenops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paratriaenops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1615588;

    /// <inheritdoc />
    public virtual string GenusName => "Paratriaenops";

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
