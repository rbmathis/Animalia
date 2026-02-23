using AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Streptopelia;

/// <summary>
/// Abstract class for Streptopelia (genus).
/// NCBI TaxId: 36242
/// </summary>
public abstract class Streptopelia : Columbidae, IStreptopelia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Streptopelia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36242;

    /// <inheritdoc />
    public virtual string GenusName => "Streptopelia";

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
