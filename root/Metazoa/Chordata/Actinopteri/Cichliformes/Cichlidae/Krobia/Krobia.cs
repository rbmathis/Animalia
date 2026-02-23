using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Krobia;

/// <summary>
/// Abstract class for Krobia (genus).
/// NCBI TaxId: 449281
/// </summary>
public abstract class Krobia : Cichlidae, IKrobia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Krobia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 449281;

    /// <inheritdoc />
    public virtual string GenusName => "Krobia";

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
