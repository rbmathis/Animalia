using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae.Ladislavia;

/// <summary>
/// Abstract class for Ladislavia (genus).
/// NCBI TaxId: 564175
/// </summary>
public abstract class Ladislavia : Gobionidae, ILadislavia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ladislavia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 564175;

    /// <inheritdoc />
    public virtual string GenusName => "Ladislavia";

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
