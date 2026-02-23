using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae.Hyladelphys;

/// <summary>
/// Abstract class for Hyladelphys (genus).
/// NCBI TaxId: 342584
/// </summary>
public abstract class Hyladelphys : Didelphidae, IHyladelphys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hyladelphys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 342584;

    /// <inheritdoc />
    public virtual string GenusName => "Hyladelphys";

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
