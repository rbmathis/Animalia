using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Megaxenops;

/// <summary>
/// Abstract class for Megaxenops (genus).
/// NCBI TaxId: 329517
/// </summary>
public abstract class Megaxenops : Furnariidae, IMegaxenops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Megaxenops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 329517;

    /// <inheritdoc />
    public virtual string GenusName => "Megaxenops";

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
