using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Phocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Phocidae.Monachus;

/// <summary>
/// Abstract class for Monachus (genus).
/// NCBI TaxId: 29087
/// </summary>
public abstract class Monachus : Phocidae, IMonachus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Monachus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 29087;

    /// <inheritdoc />
    public virtual string GenusName => "Monachus";

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
