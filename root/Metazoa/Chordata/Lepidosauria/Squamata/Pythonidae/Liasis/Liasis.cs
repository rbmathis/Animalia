using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pythonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pythonidae.Liasis;

/// <summary>
/// Abstract class for Liasis (genus).
/// NCBI TaxId: 51886
/// </summary>
public abstract class Liasis : Pythonidae, ILiasis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Liasis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 51886;

    /// <inheritdoc />
    public virtual string GenusName => "Liasis";

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
