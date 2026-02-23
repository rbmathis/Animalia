using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Exocoetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Exocoetidae.Cheilopogon;

/// <summary>
/// Abstract class for Cheilopogon (genus).
/// NCBI TaxId: 293908
/// </summary>
public abstract class Cheilopogon : Exocoetidae, ICheilopogon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cheilopogon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 293908;

    /// <inheritdoc />
    public virtual string GenusName => "Cheilopogon";

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
