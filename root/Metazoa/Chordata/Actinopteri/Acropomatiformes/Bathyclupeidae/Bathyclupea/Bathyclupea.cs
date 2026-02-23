using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Bathyclupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Bathyclupeidae.Bathyclupea;

/// <summary>
/// Abstract class for Bathyclupea (genus).
/// NCBI TaxId: 463602
/// </summary>
public abstract class Bathyclupea : Bathyclupeidae, IBathyclupea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bathyclupea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 463602;

    /// <inheritdoc />
    public virtual string GenusName => "Bathyclupea";

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
