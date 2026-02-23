using AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Uropelia;

/// <summary>
/// Abstract class for Uropelia (genus).
/// NCBI TaxId: 444152
/// </summary>
public abstract class Uropelia : Columbidae, IUropelia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Uropelia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 444152;

    /// <inheritdoc />
    public virtual string GenusName => "Uropelia";

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
