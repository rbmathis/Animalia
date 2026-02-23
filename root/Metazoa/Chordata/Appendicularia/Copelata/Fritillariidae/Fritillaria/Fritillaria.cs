using AnimalKingdom.root.Metazoa.Chordata.Appendicularia.Copelata.Fritillariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Appendicularia.Copelata.Fritillariidae.Fritillaria;

/// <summary>
/// Abstract class for Fritillaria (genus).
/// NCBI TaxId: 2507559
/// </summary>
public abstract class Fritillaria : Fritillariidae, IFritillaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Fritillaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2507559;

    /// <inheritdoc />
    public virtual string GenusName => "Fritillaria";

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
