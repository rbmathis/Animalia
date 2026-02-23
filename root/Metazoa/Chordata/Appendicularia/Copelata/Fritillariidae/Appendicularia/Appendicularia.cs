using AnimalKingdom.root.Metazoa.Chordata.Appendicularia.Copelata.Fritillariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Appendicularia.Copelata.Fritillariidae.Appendicularia;

/// <summary>
/// Abstract class for Appendicularia (genus).
/// NCBI TaxId: 2547639
/// </summary>
public abstract class Appendicularia : Fritillariidae, IAppendicularia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Appendicularia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2547639;

    /// <inheritdoc />
    public virtual string GenusName => "Appendicularia";

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
