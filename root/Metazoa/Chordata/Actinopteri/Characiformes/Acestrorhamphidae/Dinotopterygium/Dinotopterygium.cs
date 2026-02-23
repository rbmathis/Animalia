using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Dinotopterygium;

/// <summary>
/// Abstract class for Dinotopterygium (genus).
/// NCBI TaxId: 2902919
/// </summary>
public abstract class Dinotopterygium : Acestrorhamphidae, IDinotopterygium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dinotopterygium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2902919;

    /// <inheritdoc />
    public virtual string GenusName => "Dinotopterygium";

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
