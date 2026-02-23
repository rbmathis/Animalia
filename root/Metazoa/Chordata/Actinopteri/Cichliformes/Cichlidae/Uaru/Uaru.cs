using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Uaru;

/// <summary>
/// Abstract class for Uaru (genus).
/// NCBI TaxId: 74136
/// </summary>
public abstract class Uaru : Cichlidae, IUaru
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Uaru";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 74136;

    /// <inheritdoc />
    public virtual string GenusName => "Uaru";

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
