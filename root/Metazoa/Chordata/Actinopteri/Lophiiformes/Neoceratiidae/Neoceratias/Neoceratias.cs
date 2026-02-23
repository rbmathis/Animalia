using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Neoceratiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Neoceratiidae.Neoceratias;

/// <summary>
/// Abstract class for Neoceratias (genus).
/// NCBI TaxId: 412629
/// </summary>
public abstract class Neoceratias : Neoceratiidae, INeoceratias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neoceratias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 412629;

    /// <inheritdoc />
    public virtual string GenusName => "Neoceratias";

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
