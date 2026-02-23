using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Cistugidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Cistugidae.Cistugo;

/// <summary>
/// Abstract class for Cistugo (genus).
/// NCBI TaxId: 712047
/// </summary>
public abstract class Cistugo : Cistugidae, ICistugo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cistugo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 712047;

    /// <inheritdoc />
    public virtual string GenusName => "Cistugo";

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
