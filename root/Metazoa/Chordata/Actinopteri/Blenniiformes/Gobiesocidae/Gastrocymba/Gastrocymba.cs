using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Gastrocymba;

/// <summary>
/// Abstract class for Gastrocymba (genus).
/// NCBI TaxId: 2740773
/// </summary>
public abstract class Gastrocymba : Gobiesocidae, IGastrocymba
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gastrocymba";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2740773;

    /// <inheritdoc />
    public virtual string GenusName => "Gastrocymba";

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
