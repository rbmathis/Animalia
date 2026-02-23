using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Acyrtops;

/// <summary>
/// Abstract class for Acyrtops (genus).
/// NCBI TaxId: 722516
/// </summary>
public abstract class Acyrtops : Gobiesocidae, IAcyrtops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acyrtops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 722516;

    /// <inheritdoc />
    public virtual string GenusName => "Acyrtops";

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
