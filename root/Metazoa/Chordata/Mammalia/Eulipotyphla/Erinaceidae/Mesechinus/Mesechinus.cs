using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Erinaceidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Erinaceidae.Mesechinus;

/// <summary>
/// Abstract class for Mesechinus (genus).
/// NCBI TaxId: 111451
/// </summary>
public abstract class Mesechinus : Erinaceidae, IMesechinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mesechinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 111451;

    /// <inheritdoc />
    public virtual string GenusName => "Mesechinus";

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
