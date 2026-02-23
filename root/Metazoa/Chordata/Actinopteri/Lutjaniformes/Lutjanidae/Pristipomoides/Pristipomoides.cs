using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae.Pristipomoides;

/// <summary>
/// Abstract class for Pristipomoides (genus).
/// NCBI TaxId: 40510
/// </summary>
public abstract class Pristipomoides : Lutjanidae, IPristipomoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pristipomoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 40510;

    /// <inheritdoc />
    public virtual string GenusName => "Pristipomoides";

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
