using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Citharinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Citharinidae.Phago;

/// <summary>
/// Abstract class for Phago (genus).
/// NCBI TaxId: 331145
/// </summary>
public abstract class Phago : Citharinidae, IPhago
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phago";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 331145;

    /// <inheritdoc />
    public virtual string GenusName => "Phago";

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
