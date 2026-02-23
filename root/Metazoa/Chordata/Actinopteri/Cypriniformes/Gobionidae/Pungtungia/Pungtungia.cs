using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae.Pungtungia;

/// <summary>
/// Abstract class for Pungtungia (genus).
/// NCBI TaxId: 90752
/// </summary>
public abstract class Pungtungia : Gobionidae, IPungtungia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pungtungia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 90752;

    /// <inheritdoc />
    public virtual string GenusName => "Pungtungia";

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
