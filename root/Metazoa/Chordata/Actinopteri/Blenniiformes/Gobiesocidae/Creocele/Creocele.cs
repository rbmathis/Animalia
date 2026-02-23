using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Creocele;

/// <summary>
/// Abstract class for Creocele (genus).
/// NCBI TaxId: 2578375
/// </summary>
public abstract class Creocele : Gobiesocidae, ICreocele
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Creocele";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2578375;

    /// <inheritdoc />
    public virtual string GenusName => "Creocele";

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
