using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Laetacara;

/// <summary>
/// Abstract class for Laetacara (genus).
/// NCBI TaxId: 74124
/// </summary>
public abstract class Laetacara : Cichlidae, ILaetacara
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Laetacara";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 74124;

    /// <inheritdoc />
    public virtual string GenusName => "Laetacara";

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
