using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae.Microphysogobio;

/// <summary>
/// Abstract class for Microphysogobio (genus).
/// NCBI TaxId: 328542
/// </summary>
public abstract class Microphysogobio : Gobionidae, IMicrophysogobio
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microphysogobio";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 328542;

    /// <inheritdoc />
    public virtual string GenusName => "Microphysogobio";

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
