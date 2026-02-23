using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Arcos;

/// <summary>
/// Abstract class for Arcos (genus).
/// NCBI TaxId: 181473
/// </summary>
public abstract class Arcos : Gobiesocidae, IArcos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Arcos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 181473;

    /// <inheritdoc />
    public virtual string GenusName => "Arcos";

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
