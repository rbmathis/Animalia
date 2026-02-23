using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Opisthoproctidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Opisthoproctidae.Dolichopteryx;

/// <summary>
/// Abstract class for Dolichopteryx (genus).
/// NCBI TaxId: 700693
/// </summary>
public abstract class Dolichopteryx : Opisthoproctidae, IDolichopteryx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dolichopteryx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 700693;

    /// <inheritdoc />
    public virtual string GenusName => "Dolichopteryx";

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
