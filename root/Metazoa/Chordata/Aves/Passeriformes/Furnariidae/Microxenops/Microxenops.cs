using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Microxenops;

/// <summary>
/// Abstract class for Microxenops (genus).
/// NCBI TaxId: 2823045
/// </summary>
public abstract class Microxenops : Furnariidae, IMicroxenops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microxenops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2823045;

    /// <inheritdoc />
    public virtual string GenusName => "Microxenops";

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
