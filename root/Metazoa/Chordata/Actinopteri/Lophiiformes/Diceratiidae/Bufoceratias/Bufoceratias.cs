using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Diceratiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Diceratiidae.Bufoceratias;

/// <summary>
/// Abstract class for Bufoceratias (genus).
/// NCBI TaxId: 412632
/// </summary>
public abstract class Bufoceratias : Diceratiidae, IBufoceratias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bufoceratias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 412632;

    /// <inheritdoc />
    public virtual string GenusName => "Bufoceratias";

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
