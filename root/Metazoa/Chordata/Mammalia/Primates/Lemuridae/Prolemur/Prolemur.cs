using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lemuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lemuridae.Prolemur;

/// <summary>
/// Abstract class for Prolemur (genus).
/// NCBI TaxId: 1328069
/// </summary>
public abstract class Prolemur : Lemuridae, IProlemur
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Prolemur";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1328069;

    /// <inheritdoc />
    public virtual string GenusName => "Prolemur";

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
