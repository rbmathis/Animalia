using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae.Nyctinomops;

/// <summary>
/// Abstract class for Nyctinomops (genus).
/// NCBI TaxId: 27625
/// </summary>
public abstract class Nyctinomops : Molossidae, INyctinomops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nyctinomops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27625;

    /// <inheritdoc />
    public virtual string GenusName => "Nyctinomops";

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
