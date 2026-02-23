using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Triakidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Triakidae.Galeorhinus;

/// <summary>
/// Abstract class for Galeorhinus (genus).
/// NCBI TaxId: 7874
/// </summary>
public abstract class Galeorhinus : Triakidae, IGaleorhinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Galeorhinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7874;

    /// <inheritdoc />
    public virtual string GenusName => "Galeorhinus";

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
