using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae.Gobio;

/// <summary>
/// Abstract class for Gobio (genus).
/// NCBI TaxId: 27703
/// </summary>
public abstract class Gobio : Gobionidae, IGobio
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gobio";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27703;

    /// <inheritdoc />
    public virtual string GenusName => "Gobio";

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
