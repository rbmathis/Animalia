using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Sueviota;

/// <summary>
/// Abstract class for Sueviota (genus).
/// NCBI TaxId: 1840529
/// </summary>
public abstract class Sueviota : Gobiidae, ISueviota
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sueviota";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1840529;

    /// <inheritdoc />
    public virtual string GenusName => "Sueviota";

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
