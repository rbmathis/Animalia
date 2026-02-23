using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Ceratiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Ceratiidae.Cryptopsaras;

/// <summary>
/// Abstract class for Cryptopsaras (genus).
/// NCBI TaxId: 302052
/// </summary>
public abstract class Cryptopsaras : Ceratiidae, ICryptopsaras
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cryptopsaras";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 302052;

    /// <inheritdoc />
    public virtual string GenusName => "Cryptopsaras";

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
