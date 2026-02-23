using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae.Scalopus;

/// <summary>
/// Abstract class for Scalopus (genus).
/// NCBI TaxId: 71118
/// </summary>
public abstract class Scalopus : Talpidae, IScalopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scalopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 71118;

    /// <inheritdoc />
    public virtual string GenusName => "Scalopus";

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
