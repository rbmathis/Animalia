using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Chocoheros;

/// <summary>
/// Abstract class for Chocoheros (genus).
/// NCBI TaxId: 2302650
/// </summary>
public abstract class Chocoheros : Cichlidae, IChocoheros
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chocoheros";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2302650;

    /// <inheritdoc />
    public virtual string GenusName => "Chocoheros";

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
