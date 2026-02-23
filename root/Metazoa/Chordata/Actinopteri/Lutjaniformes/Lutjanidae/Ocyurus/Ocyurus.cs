using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae.Ocyurus;

/// <summary>
/// Abstract class for Ocyurus (genus).
/// NCBI TaxId: 40498
/// </summary>
public abstract class Ocyurus : Lutjanidae, IOcyurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ocyurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 40498;

    /// <inheritdoc />
    public virtual string GenusName => "Ocyurus";

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
