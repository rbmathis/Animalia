using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Philydor;

/// <summary>
/// Abstract class for Philydor (genus).
/// NCBI TaxId: 183164
/// </summary>
public abstract class Philydor : Furnariidae, IPhilydor
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Philydor";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 183164;

    /// <inheritdoc />
    public virtual string GenusName => "Philydor";

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
