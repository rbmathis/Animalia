using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae.Rhinogobio;

/// <summary>
/// Abstract class for Rhinogobio (genus).
/// NCBI TaxId: 171526
/// </summary>
public abstract class Rhinogobio : Gobionidae, IRhinogobio
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhinogobio";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 171526;

    /// <inheritdoc />
    public virtual string GenusName => "Rhinogobio";

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
