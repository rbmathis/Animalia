using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lemuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lemuridae.Lemur;

/// <summary>
/// Abstract class for Lemur (genus).
/// NCBI TaxId: 9446
/// </summary>
public abstract class Lemur : Lemuridae, ILemur
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lemur";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9446;

    /// <inheritdoc />
    public virtual string GenusName => "Lemur";

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
