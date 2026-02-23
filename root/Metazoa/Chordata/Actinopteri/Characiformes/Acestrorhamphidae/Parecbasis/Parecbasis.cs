using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Parecbasis;

/// <summary>
/// Abstract class for Parecbasis (genus).
/// NCBI TaxId: 930366
/// </summary>
public abstract class Parecbasis : Acestrorhamphidae, IParecbasis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parecbasis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 930366;

    /// <inheritdoc />
    public virtual string GenusName => "Parecbasis";

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
