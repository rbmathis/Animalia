using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Ctenobrycon;

/// <summary>
/// Abstract class for Ctenobrycon (genus).
/// NCBI TaxId: 642579
/// </summary>
public abstract class Ctenobrycon : Acestrorhamphidae, ICtenobrycon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ctenobrycon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 642579;

    /// <inheritdoc />
    public virtual string GenusName => "Ctenobrycon";

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
