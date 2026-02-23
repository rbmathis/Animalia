using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Buccochromis;

/// <summary>
/// Abstract class for Buccochromis (genus).
/// NCBI TaxId: 32489
/// </summary>
public abstract class Buccochromis : Cichlidae, IBuccochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Buccochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 32489;

    /// <inheritdoc />
    public virtual string GenusName => "Buccochromis";

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
