using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Trachinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Trachinidae.Trachinus;

/// <summary>
/// Abstract class for Trachinus (genus).
/// NCBI TaxId: 56736
/// </summary>
public abstract class Trachinus : Trachinidae, ITrachinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trachinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56736;

    /// <inheritdoc />
    public virtual string GenusName => "Trachinus";

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
