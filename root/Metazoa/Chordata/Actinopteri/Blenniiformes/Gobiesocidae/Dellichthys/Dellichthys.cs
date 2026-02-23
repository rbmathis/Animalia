using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Dellichthys;

/// <summary>
/// Abstract class for Dellichthys (genus).
/// NCBI TaxId: 2108451
/// </summary>
public abstract class Dellichthys : Gobiesocidae, IDellichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dellichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2108451;

    /// <inheritdoc />
    public virtual string GenusName => "Dellichthys";

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
