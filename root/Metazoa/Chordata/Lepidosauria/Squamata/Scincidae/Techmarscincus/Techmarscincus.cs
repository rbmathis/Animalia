using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Techmarscincus;

/// <summary>
/// Abstract class for Techmarscincus (genus).
/// NCBI TaxId: 1384676
/// </summary>
public abstract class Techmarscincus : Scincidae, ITechmarscincus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Techmarscincus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1384676;

    /// <inheritdoc />
    public virtual string GenusName => "Techmarscincus";

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
