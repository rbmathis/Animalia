using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Gastrocyathus;

/// <summary>
/// Abstract class for Gastrocyathus (genus).
/// NCBI TaxId: 2740779
/// </summary>
public abstract class Gastrocyathus : Gobiesocidae, IGastrocyathus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gastrocyathus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2740779;

    /// <inheritdoc />
    public virtual string GenusName => "Gastrocyathus";

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
