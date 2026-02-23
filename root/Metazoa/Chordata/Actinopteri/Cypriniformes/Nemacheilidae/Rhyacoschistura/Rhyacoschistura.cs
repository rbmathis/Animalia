using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Rhyacoschistura;

/// <summary>
/// Abstract class for Rhyacoschistura (genus).
/// NCBI TaxId: 3119490
/// </summary>
public abstract class Rhyacoschistura : Nemacheilidae, IRhyacoschistura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhyacoschistura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3119490;

    /// <inheritdoc />
    public virtual string GenusName => "Rhyacoschistura";

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
