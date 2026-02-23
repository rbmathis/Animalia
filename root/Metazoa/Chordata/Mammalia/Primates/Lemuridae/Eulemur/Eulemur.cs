using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lemuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lemuridae.Eulemur;

/// <summary>
/// Abstract class for Eulemur (genus).
/// NCBI TaxId: 13513
/// </summary>
public abstract class Eulemur : Lemuridae, IEulemur
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eulemur";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 13513;

    /// <inheritdoc />
    public virtual string GenusName => "Eulemur";

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
