using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Lophogobius;

/// <summary>
/// Abstract class for Lophogobius (genus).
/// NCBI TaxId: 151730
/// </summary>
public abstract class Lophogobius : Gobiidae, ILophogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lophogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 151730;

    /// <inheritdoc />
    public virtual string GenusName => "Lophogobius";

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
