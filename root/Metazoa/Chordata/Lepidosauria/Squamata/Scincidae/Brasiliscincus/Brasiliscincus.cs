using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Brasiliscincus;

/// <summary>
/// Abstract class for Brasiliscincus (genus).
/// NCBI TaxId: 1332673
/// </summary>
public abstract class Brasiliscincus : Scincidae, IBrasiliscincus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brasiliscincus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1332673;

    /// <inheritdoc />
    public virtual string GenusName => "Brasiliscincus";

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
