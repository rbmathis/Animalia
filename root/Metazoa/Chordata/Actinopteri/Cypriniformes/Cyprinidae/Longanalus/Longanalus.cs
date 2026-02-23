using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Longanalus;

/// <summary>
/// Abstract class for Longanalus (genus).
/// NCBI TaxId: 3362302
/// </summary>
public abstract class Longanalus : Cyprinidae, ILonganalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Longanalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3362302;

    /// <inheritdoc />
    public virtual string GenusName => "Longanalus";

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
