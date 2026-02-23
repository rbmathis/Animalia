using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Physoschistura;

/// <summary>
/// Abstract class for Physoschistura (genus).
/// NCBI TaxId: 1758144
/// </summary>
public abstract class Physoschistura : Nemacheilidae, IPhysoschistura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Physoschistura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1758144;

    /// <inheritdoc />
    public virtual string GenusName => "Physoschistura";

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
