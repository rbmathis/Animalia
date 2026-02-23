using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Parahydrophis;

/// <summary>
/// Abstract class for Parahydrophis (genus).
/// NCBI TaxId: 355701
/// </summary>
public abstract class Parahydrophis : Elapidae, IParahydrophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parahydrophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 355701;

    /// <inheritdoc />
    public virtual string GenusName => "Parahydrophis";

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
