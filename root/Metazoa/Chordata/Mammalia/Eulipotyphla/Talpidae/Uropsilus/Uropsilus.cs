using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae.Uropsilus;

/// <summary>
/// Abstract class for Uropsilus (genus).
/// NCBI TaxId: 176848
/// </summary>
public abstract class Uropsilus : Talpidae, IUropsilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Uropsilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 176848;

    /// <inheritdoc />
    public virtual string GenusName => "Uropsilus";

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
