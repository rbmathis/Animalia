using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Triacanthodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Triacanthodidae.Mephisto;

/// <summary>
/// Abstract class for Mephisto (genus).
/// NCBI TaxId: 3115287
/// </summary>
public abstract class Mephisto : Triacanthodidae, IMephisto
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mephisto";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3115287;

    /// <inheritdoc />
    public virtual string GenusName => "Mephisto";

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
