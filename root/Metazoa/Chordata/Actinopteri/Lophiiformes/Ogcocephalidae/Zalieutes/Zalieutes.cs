using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Ogcocephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Ogcocephalidae.Zalieutes;

/// <summary>
/// Abstract class for Zalieutes (genus).
/// NCBI TaxId: 412626
/// </summary>
public abstract class Zalieutes : Ogcocephalidae, IZalieutes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zalieutes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 412626;

    /// <inheritdoc />
    public virtual string GenusName => "Zalieutes";

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
