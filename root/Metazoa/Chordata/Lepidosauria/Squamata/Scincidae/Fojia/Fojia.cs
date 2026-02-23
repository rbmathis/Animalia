using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Fojia;

/// <summary>
/// Abstract class for Fojia (genus).
/// NCBI TaxId: 1544883
/// </summary>
public abstract class Fojia : Scincidae, IFojia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Fojia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1544883;

    /// <inheritdoc />
    public virtual string GenusName => "Fojia";

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
