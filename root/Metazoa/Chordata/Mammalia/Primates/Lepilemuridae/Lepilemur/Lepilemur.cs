using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lepilemuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lepilemuridae.Lepilemur;

/// <summary>
/// Abstract class for Lepilemur (genus).
/// NCBI TaxId: 9452
/// </summary>
public abstract class Lepilemur : Lepilemuridae, ILepilemur
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lepilemur";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9452;

    /// <inheritdoc />
    public virtual string GenusName => "Lepilemur";

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
