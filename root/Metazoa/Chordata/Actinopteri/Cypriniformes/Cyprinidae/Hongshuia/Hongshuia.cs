using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Hongshuia;

/// <summary>
/// Abstract class for Hongshuia (genus).
/// NCBI TaxId: 887919
/// </summary>
public abstract class Hongshuia : Cyprinidae, IHongshuia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hongshuia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 887919;

    /// <inheritdoc />
    public virtual string GenusName => "Hongshuia";

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
