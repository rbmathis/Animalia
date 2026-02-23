using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Tetrarogidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Tetrarogidae.Tetraroge;

/// <summary>
/// Abstract class for Tetraroge (genus).
/// NCBI TaxId: 1522440
/// </summary>
public abstract class Tetraroge : Tetrarogidae, ITetraroge
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tetraroge";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1522440;

    /// <inheritdoc />
    public virtual string GenusName => "Tetraroge";

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
