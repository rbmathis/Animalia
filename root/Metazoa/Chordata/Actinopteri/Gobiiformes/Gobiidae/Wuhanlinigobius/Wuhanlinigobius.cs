using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Wuhanlinigobius;

/// <summary>
/// Abstract class for Wuhanlinigobius (genus).
/// NCBI TaxId: 2905713
/// </summary>
public abstract class Wuhanlinigobius : Gobiidae, IWuhanlinigobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Wuhanlinigobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2905713;

    /// <inheritdoc />
    public virtual string GenusName => "Wuhanlinigobius";

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
