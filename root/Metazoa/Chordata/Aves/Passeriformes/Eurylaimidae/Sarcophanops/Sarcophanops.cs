using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Eurylaimidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Eurylaimidae.Sarcophanops;

/// <summary>
/// Abstract class for Sarcophanops (genus).
/// NCBI TaxId: 2527946
/// </summary>
public abstract class Sarcophanops : Eurylaimidae, ISarcophanops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sarcophanops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2527946;

    /// <inheritdoc />
    public virtual string GenusName => "Sarcophanops";

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
