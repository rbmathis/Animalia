using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Pherallodiscus;

/// <summary>
/// Abstract class for Pherallodiscus (genus).
/// NCBI TaxId: 1986070
/// </summary>
public abstract class Pherallodiscus : Gobiesocidae, IPherallodiscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pherallodiscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1986070;

    /// <inheritdoc />
    public virtual string GenusName => "Pherallodiscus";

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
