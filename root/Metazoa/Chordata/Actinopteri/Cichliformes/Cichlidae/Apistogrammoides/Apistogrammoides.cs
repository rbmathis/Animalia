using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Apistogrammoides;

/// <summary>
/// Abstract class for Apistogrammoides (genus).
/// NCBI TaxId: 284703
/// </summary>
public abstract class Apistogrammoides : Cichlidae, IApistogrammoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Apistogrammoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 284703;

    /// <inheritdoc />
    public virtual string GenusName => "Apistogrammoides";

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
