using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Conidens;

/// <summary>
/// Abstract class for Conidens (genus).
/// NCBI TaxId: 1772064
/// </summary>
public abstract class Conidens : Gobiesocidae, IConidens
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Conidens";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1772064;

    /// <inheritdoc />
    public virtual string GenusName => "Conidens";

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
