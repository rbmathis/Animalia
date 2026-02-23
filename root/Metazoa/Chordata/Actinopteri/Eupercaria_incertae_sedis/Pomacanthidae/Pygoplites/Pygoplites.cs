using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Pomacanthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Pomacanthidae.Pygoplites;

/// <summary>
/// Abstract class for Pygoplites (genus).
/// NCBI TaxId: 109740
/// </summary>
public abstract class Pygoplites : Pomacanthidae, IPygoplites
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pygoplites";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 109740;

    /// <inheritdoc />
    public virtual string GenusName => "Pygoplites";

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
