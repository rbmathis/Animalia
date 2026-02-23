using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Bathyclupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Bathyclupeidae.Neobathyclupea;

/// <summary>
/// Abstract class for Neobathyclupea (genus).
/// NCBI TaxId: 2306608
/// </summary>
public abstract class Neobathyclupea : Bathyclupeidae, INeobathyclupea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neobathyclupea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2306608;

    /// <inheritdoc />
    public virtual string GenusName => "Neobathyclupea";

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
