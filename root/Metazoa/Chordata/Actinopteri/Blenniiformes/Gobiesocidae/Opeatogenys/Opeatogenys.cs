using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Opeatogenys;

/// <summary>
/// Abstract class for Opeatogenys (genus).
/// NCBI TaxId: 210030
/// </summary>
public abstract class Opeatogenys : Gobiesocidae, IOpeatogenys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Opeatogenys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 210030;

    /// <inheritdoc />
    public virtual string GenusName => "Opeatogenys";

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
