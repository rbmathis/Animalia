using AnimalKingdom.root.Metazoa.Chordata.Aves.Struthioniformes.Struthionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Struthioniformes.Struthionidae.Struthio;

/// <summary>
/// Abstract class for Struthio (genus).
/// NCBI TaxId: 8800
/// </summary>
public abstract class Struthio : Struthionidae, IStruthio
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Struthio";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8800;

    /// <inheritdoc />
    public virtual string GenusName => "Struthio";

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
