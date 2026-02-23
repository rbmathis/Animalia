using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Guianacara;

/// <summary>
/// Abstract class for Guianacara (genus).
/// NCBI TaxId: 81352
/// </summary>
public abstract class Guianacara : Cichlidae, IGuianacara
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Guianacara";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 81352;

    /// <inheritdoc />
    public virtual string GenusName => "Guianacara";

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
