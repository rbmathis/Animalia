using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae.Symphorichthys;

/// <summary>
/// Abstract class for Symphorichthys (genus).
/// NCBI TaxId: 396795
/// </summary>
public abstract class Symphorichthys : Lutjanidae, ISymphorichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Symphorichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 396795;

    /// <inheritdoc />
    public virtual string GenusName => "Symphorichthys";

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
