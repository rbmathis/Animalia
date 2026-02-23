using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lemuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lemuridae.Pachylemur;

/// <summary>
/// Abstract class for Pachylemur (genus).
/// NCBI TaxId: 1513474
/// </summary>
public abstract class Pachylemur : Lemuridae, IPachylemur
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pachylemur";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1513474;

    /// <inheritdoc />
    public virtual string GenusName => "Pachylemur";

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
