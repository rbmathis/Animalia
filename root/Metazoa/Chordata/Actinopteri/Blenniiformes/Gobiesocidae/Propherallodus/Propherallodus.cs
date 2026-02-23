using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Propherallodus;

/// <summary>
/// Abstract class for Propherallodus (genus).
/// NCBI TaxId: 2589279
/// </summary>
public abstract class Propherallodus : Gobiesocidae, IPropherallodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Propherallodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2589279;

    /// <inheritdoc />
    public virtual string GenusName => "Propherallodus";

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
