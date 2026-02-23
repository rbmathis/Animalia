using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Onychostoma;

/// <summary>
/// Abstract class for Onychostoma (genus).
/// NCBI TaxId: 369638
/// </summary>
public abstract class Onychostoma : Cyprinidae, IOnychostoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Onychostoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 369638;

    /// <inheritdoc />
    public virtual string GenusName => "Onychostoma";

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
