using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Aniliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Aniliidae.Anilius;

/// <summary>
/// Abstract class for Anilius (genus).
/// NCBI TaxId: 51843
/// </summary>
public abstract class Anilius : Aniliidae, IAnilius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anilius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 51843;

    /// <inheritdoc />
    public virtual string GenusName => "Anilius";

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
