using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Chamaeleonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Chamaeleonidae.Archaius;

/// <summary>
/// Abstract class for Archaius (genus).
/// NCBI TaxId: 886577
/// </summary>
public abstract class Archaius : Chamaeleonidae, IArchaius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Archaius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 886577;

    /// <inheritdoc />
    public virtual string GenusName => "Archaius";

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
