using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Erythrocharax;

/// <summary>
/// Abstract class for Erythrocharax (genus).
/// NCBI TaxId: 1282339
/// </summary>
public abstract class Erythrocharax : Acestrorhamphidae, IErythrocharax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Erythrocharax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1282339;

    /// <inheritdoc />
    public virtual string GenusName => "Erythrocharax";

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
