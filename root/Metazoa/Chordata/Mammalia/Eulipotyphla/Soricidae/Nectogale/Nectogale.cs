using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Nectogale;

/// <summary>
/// Abstract class for Nectogale (genus).
/// NCBI TaxId: 268757
/// </summary>
public abstract class Nectogale : Soricidae, INectogale
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nectogale";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 268757;

    /// <inheritdoc />
    public virtual string GenusName => "Nectogale";

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
