using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae.Otomops;

/// <summary>
/// Abstract class for Otomops (genus).
/// NCBI TaxId: 258866
/// </summary>
public abstract class Otomops : Molossidae, IOtomops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Otomops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 258866;

    /// <inheritdoc />
    public virtual string GenusName => "Otomops";

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
