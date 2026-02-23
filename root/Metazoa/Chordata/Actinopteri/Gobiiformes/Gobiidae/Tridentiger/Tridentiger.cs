using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Tridentiger;

/// <summary>
/// Abstract class for Tridentiger (genus).
/// NCBI TaxId: 55552
/// </summary>
public abstract class Tridentiger : Gobiidae, ITridentiger
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tridentiger";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 55552;

    /// <inheritdoc />
    public virtual string GenusName => "Tridentiger";

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
