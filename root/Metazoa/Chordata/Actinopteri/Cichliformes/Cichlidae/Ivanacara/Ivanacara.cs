using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Ivanacara;

/// <summary>
/// Abstract class for Ivanacara (genus).
/// NCBI TaxId: 2021277
/// </summary>
public abstract class Ivanacara : Cichlidae, IIvanacara
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ivanacara";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2021277;

    /// <inheritdoc />
    public virtual string GenusName => "Ivanacara";

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
