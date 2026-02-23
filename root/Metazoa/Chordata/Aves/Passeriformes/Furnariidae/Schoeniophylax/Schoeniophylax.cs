using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Schoeniophylax;

/// <summary>
/// Abstract class for Schoeniophylax (genus).
/// NCBI TaxId: 329495
/// </summary>
public abstract class Schoeniophylax : Furnariidae, ISchoeniophylax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Schoeniophylax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 329495;

    /// <inheritdoc />
    public virtual string GenusName => "Schoeniophylax";

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
