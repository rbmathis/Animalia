using AnimalKingdom.root.Metazoa.Chordata.Aves.Pterocliformes.Pteroclidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pterocliformes.Pteroclidae.Pterocles;

/// <summary>
/// Abstract class for Pterocles (genus).
/// NCBI TaxId: 56296
/// </summary>
public abstract class Pterocles : Pteroclidae, IPterocles
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pterocles";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56296;

    /// <inheritdoc />
    public virtual string GenusName => "Pterocles";

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
