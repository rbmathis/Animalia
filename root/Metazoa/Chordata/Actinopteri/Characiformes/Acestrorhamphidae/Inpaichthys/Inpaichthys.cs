using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Inpaichthys;

/// <summary>
/// Abstract class for Inpaichthys (genus).
/// NCBI TaxId: 304041
/// </summary>
public abstract class Inpaichthys : Acestrorhamphidae, IInpaichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Inpaichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 304041;

    /// <inheritdoc />
    public virtual string GenusName => "Inpaichthys";

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
