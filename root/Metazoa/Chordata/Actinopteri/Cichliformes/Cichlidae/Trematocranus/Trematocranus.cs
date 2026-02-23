using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Trematocranus;

/// <summary>
/// Abstract class for Trematocranus (genus).
/// NCBI TaxId: 323799
/// </summary>
public abstract class Trematocranus : Cichlidae, ITrematocranus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trematocranus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 323799;

    /// <inheritdoc />
    public virtual string GenusName => "Trematocranus";

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
