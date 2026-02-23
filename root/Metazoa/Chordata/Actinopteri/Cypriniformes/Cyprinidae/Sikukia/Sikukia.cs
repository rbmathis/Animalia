using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Sikukia;

/// <summary>
/// Abstract class for Sikukia (genus).
/// NCBI TaxId: 369622
/// </summary>
public abstract class Sikukia : Cyprinidae, ISikukia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sikukia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 369622;

    /// <inheritdoc />
    public virtual string GenusName => "Sikukia";

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
