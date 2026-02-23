using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Hypsibarbus;

/// <summary>
/// Abstract class for Hypsibarbus (genus).
/// NCBI TaxId: 370358
/// </summary>
public abstract class Hypsibarbus : Cyprinidae, IHypsibarbus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypsibarbus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 370358;

    /// <inheritdoc />
    public virtual string GenusName => "Hypsibarbus";

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
