using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Lissolepis;

/// <summary>
/// Abstract class for Lissolepis (genus).
/// NCBI TaxId: 1041598
/// </summary>
public abstract class Lissolepis : Scincidae, ILissolepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lissolepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1041598;

    /// <inheritdoc />
    public virtual string GenusName => "Lissolepis";

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
