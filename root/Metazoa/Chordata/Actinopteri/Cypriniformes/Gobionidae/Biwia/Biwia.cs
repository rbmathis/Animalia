using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae.Biwia;

/// <summary>
/// Abstract class for Biwia (genus).
/// NCBI TaxId: 143611
/// </summary>
public abstract class Biwia : Gobionidae, IBiwia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Biwia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143611;

    /// <inheritdoc />
    public virtual string GenusName => "Biwia";

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
