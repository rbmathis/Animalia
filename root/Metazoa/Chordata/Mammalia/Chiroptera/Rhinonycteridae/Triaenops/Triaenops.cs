using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Rhinonycteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Rhinonycteridae.Triaenops;

/// <summary>
/// Abstract class for Triaenops (genus).
/// NCBI TaxId: 258842
/// </summary>
public abstract class Triaenops : Rhinonycteridae, ITriaenops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Triaenops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 258842;

    /// <inheritdoc />
    public virtual string GenusName => "Triaenops";

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
