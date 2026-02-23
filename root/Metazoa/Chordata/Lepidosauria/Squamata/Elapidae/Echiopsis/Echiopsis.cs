using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Echiopsis;

/// <summary>
/// Abstract class for Echiopsis (genus).
/// NCBI TaxId: 529691
/// </summary>
public abstract class Echiopsis : Elapidae, IEchiopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Echiopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 529691;

    /// <inheritdoc />
    public virtual string GenusName => "Echiopsis";

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
