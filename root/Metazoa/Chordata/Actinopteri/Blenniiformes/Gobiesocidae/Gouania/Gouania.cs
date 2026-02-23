using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Gouania;

/// <summary>
/// Abstract class for Gouania (genus).
/// NCBI TaxId: 210581
/// </summary>
public abstract class Gouania : Gobiesocidae, IGouania
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gouania";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 210581;

    /// <inheritdoc />
    public virtual string GenusName => "Gouania";

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
