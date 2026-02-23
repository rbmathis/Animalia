using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Pherallodus;

/// <summary>
/// Abstract class for Pherallodus (genus).
/// NCBI TaxId: 1772092
/// </summary>
public abstract class Pherallodus : Gobiesocidae, IPherallodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pherallodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1772092;

    /// <inheritdoc />
    public virtual string GenusName => "Pherallodus";

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
