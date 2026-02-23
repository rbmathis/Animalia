using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Typhlogobius;

/// <summary>
/// Abstract class for Typhlogobius (genus).
/// NCBI TaxId: 166767
/// </summary>
public abstract class Typhlogobius : Gobiidae, ITyphlogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Typhlogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 166767;

    /// <inheritdoc />
    public virtual string GenusName => "Typhlogobius";

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
