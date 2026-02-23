using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Pygarrhichas;

/// <summary>
/// Abstract class for Pygarrhichas (genus).
/// NCBI TaxId: 183188
/// </summary>
public abstract class Pygarrhichas : Furnariidae, IPygarrhichas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pygarrhichas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 183188;

    /// <inheritdoc />
    public virtual string GenusName => "Pygarrhichas";

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
