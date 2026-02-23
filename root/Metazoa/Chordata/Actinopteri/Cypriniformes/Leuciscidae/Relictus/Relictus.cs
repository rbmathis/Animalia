using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Relictus;

/// <summary>
/// Abstract class for Relictus (genus).
/// NCBI TaxId: 71770
/// </summary>
public abstract class Relictus : Leuciscidae, IRelictus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Relictus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 71770;

    /// <inheritdoc />
    public virtual string GenusName => "Relictus";

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
