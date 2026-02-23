using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Furina;

/// <summary>
/// Abstract class for Furina (genus).
/// NCBI TaxId: 529695
/// </summary>
public abstract class Furina : Elapidae, IFurina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Furina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 529695;

    /// <inheritdoc />
    public virtual string GenusName => "Furina";

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
