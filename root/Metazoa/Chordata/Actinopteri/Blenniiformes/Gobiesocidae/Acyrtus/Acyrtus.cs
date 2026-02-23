using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Acyrtus;

/// <summary>
/// Abstract class for Acyrtus (genus).
/// NCBI TaxId: 1181941
/// </summary>
public abstract class Acyrtus : Gobiesocidae, IAcyrtus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acyrtus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1181941;

    /// <inheritdoc />
    public virtual string GenusName => "Acyrtus";

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
