using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Rondonacara;

/// <summary>
/// Abstract class for Rondonacara (genus).
/// NCBI TaxId: 1725327
/// </summary>
public abstract class Rondonacara : Cichlidae, IRondonacara
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rondonacara";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1725327;

    /// <inheritdoc />
    public virtual string GenusName => "Rondonacara";

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
