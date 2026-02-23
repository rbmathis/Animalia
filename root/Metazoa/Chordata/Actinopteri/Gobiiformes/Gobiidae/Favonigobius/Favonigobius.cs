using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Favonigobius;

/// <summary>
/// Abstract class for Favonigobius (genus).
/// NCBI TaxId: 248999
/// </summary>
public abstract class Favonigobius : Gobiidae, IFavonigobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Favonigobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 248999;

    /// <inheritdoc />
    public virtual string GenusName => "Favonigobius";

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
