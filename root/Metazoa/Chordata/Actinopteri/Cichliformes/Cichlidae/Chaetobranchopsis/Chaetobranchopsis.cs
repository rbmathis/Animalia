using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Chaetobranchopsis;

/// <summary>
/// Abstract class for Chaetobranchopsis (genus).
/// NCBI TaxId: 74107
/// </summary>
public abstract class Chaetobranchopsis : Cichlidae, IChaetobranchopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chaetobranchopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 74107;

    /// <inheritdoc />
    public virtual string GenusName => "Chaetobranchopsis";

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
