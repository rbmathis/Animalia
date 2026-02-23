using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Trachelochismus;

/// <summary>
/// Abstract class for Trachelochismus (genus).
/// NCBI TaxId: 2259601
/// </summary>
public abstract class Trachelochismus : Gobiesocidae, ITrachelochismus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trachelochismus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2259601;

    /// <inheritdoc />
    public virtual string GenusName => "Trachelochismus";

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
