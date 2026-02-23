using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Ceratiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Ceratiidae.Ceratias;

/// <summary>
/// Abstract class for Ceratias (genus).
/// NCBI TaxId: 206107
/// </summary>
public abstract class Ceratias : Ceratiidae, ICeratias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ceratias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 206107;

    /// <inheritdoc />
    public virtual string GenusName => "Ceratias";

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
