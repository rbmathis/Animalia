using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Exocoetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Exocoetidae.Fodiator;

/// <summary>
/// Abstract class for Fodiator (genus).
/// NCBI TaxId: 293910
/// </summary>
public abstract class Fodiator : Exocoetidae, IFodiator
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Fodiator";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 293910;

    /// <inheritdoc />
    public virtual string GenusName => "Fodiator";

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
