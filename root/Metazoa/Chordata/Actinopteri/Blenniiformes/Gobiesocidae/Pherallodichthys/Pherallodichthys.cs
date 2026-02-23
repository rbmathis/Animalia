using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Pherallodichthys;

/// <summary>
/// Abstract class for Pherallodichthys (genus).
/// NCBI TaxId: 2740790
/// </summary>
public abstract class Pherallodichthys : Gobiesocidae, IPherallodichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pherallodichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2740790;

    /// <inheritdoc />
    public virtual string GenusName => "Pherallodichthys";

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
