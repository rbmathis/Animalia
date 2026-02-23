using AnimalKingdom.root.Metazoa.Chordata.Appendicularia.Copelata.Fritillariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Appendicularia.Copelata.Fritillariidae.Tectillaria;

/// <summary>
/// Abstract class for Tectillaria (genus).
/// NCBI TaxId: 2547649
/// </summary>
public abstract class Tectillaria : Fritillariidae, ITectillaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tectillaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2547649;

    /// <inheritdoc />
    public virtual string GenusName => "Tectillaria";

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
