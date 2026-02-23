using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Nandopsis;

/// <summary>
/// Abstract class for Nandopsis (genus).
/// NCBI TaxId: 61810
/// </summary>
public abstract class Nandopsis : Cichlidae, INandopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nandopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 61810;

    /// <inheritdoc />
    public virtual string GenusName => "Nandopsis";

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
