using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Erinaceidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Erinaceidae.Hemiechinus;

/// <summary>
/// Abstract class for Hemiechinus (genus).
/// NCBI TaxId: 30578
/// </summary>
public abstract class Hemiechinus : Erinaceidae, IHemiechinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemiechinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30578;

    /// <inheritdoc />
    public virtual string GenusName => "Hemiechinus";

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
