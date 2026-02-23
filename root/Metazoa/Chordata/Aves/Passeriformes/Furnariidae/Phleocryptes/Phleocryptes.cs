using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Phleocryptes;

/// <summary>
/// Abstract class for Phleocryptes (genus).
/// NCBI TaxId: 329488
/// </summary>
public abstract class Phleocryptes : Furnariidae, IPhleocryptes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phleocryptes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 329488;

    /// <inheritdoc />
    public virtual string GenusName => "Phleocryptes";

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
