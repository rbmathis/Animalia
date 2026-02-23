using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Viverridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Viverridae.Civettictis;

/// <summary>
/// Abstract class for Civettictis (genus).
/// NCBI TaxId: 94185
/// </summary>
public abstract class Civettictis : Viverridae, ICivettictis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Civettictis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 94185;

    /// <inheritdoc />
    public virtual string GenusName => "Civettictis";

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
