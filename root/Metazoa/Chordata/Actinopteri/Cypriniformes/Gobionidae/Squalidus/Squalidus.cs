using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae.Squalidus;

/// <summary>
/// Abstract class for Squalidus (genus).
/// NCBI TaxId: 180934
/// </summary>
public abstract class Squalidus : Gobionidae, ISqualidus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Squalidus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 180934;

    /// <inheritdoc />
    public virtual string GenusName => "Squalidus";

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
