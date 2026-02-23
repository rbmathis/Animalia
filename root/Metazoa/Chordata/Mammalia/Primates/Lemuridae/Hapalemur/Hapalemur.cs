using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lemuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lemuridae.Hapalemur;

/// <summary>
/// Abstract class for Hapalemur (genus).
/// NCBI TaxId: 13556
/// </summary>
public abstract class Hapalemur : Lemuridae, IHapalemur
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hapalemur";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 13556;

    /// <inheritdoc />
    public virtual string GenusName => "Hapalemur";

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
