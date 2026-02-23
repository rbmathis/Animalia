using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Garrulus;

/// <summary>
/// Abstract class for Garrulus (genus).
/// NCBI TaxId: 56782
/// </summary>
public abstract class Garrulus : Corvidae, IGarrulus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Garrulus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56782;

    /// <inheritdoc />
    public virtual string GenusName => "Garrulus";

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
