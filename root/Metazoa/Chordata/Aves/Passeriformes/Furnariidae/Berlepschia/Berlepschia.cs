using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Berlepschia;

/// <summary>
/// Abstract class for Berlepschia (genus).
/// NCBI TaxId: 288036
/// </summary>
public abstract class Berlepschia : Furnariidae, IBerlepschia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Berlepschia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 288036;

    /// <inheritdoc />
    public virtual string GenusName => "Berlepschia";

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
