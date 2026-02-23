using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae.Hoplopagrus;

/// <summary>
/// Abstract class for Hoplopagrus (genus).
/// NCBI TaxId: 1412449
/// </summary>
public abstract class Hoplopagrus : Lutjanidae, IHoplopagrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hoplopagrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1412449;

    /// <inheritdoc />
    public virtual string GenusName => "Hoplopagrus";

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
