using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Rimicola;

/// <summary>
/// Abstract class for Rimicola (genus).
/// NCBI TaxId: 557416
/// </summary>
public abstract class Rimicola : Gobiesocidae, IRimicola
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rimicola";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 557416;

    /// <inheritdoc />
    public virtual string GenusName => "Rimicola";

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
