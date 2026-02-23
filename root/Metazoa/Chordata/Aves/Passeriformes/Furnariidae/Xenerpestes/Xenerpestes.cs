using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Xenerpestes;

/// <summary>
/// Abstract class for Xenerpestes (genus).
/// NCBI TaxId: 329519
/// </summary>
public abstract class Xenerpestes : Furnariidae, IXenerpestes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenerpestes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 329519;

    /// <inheritdoc />
    public virtual string GenusName => "Xenerpestes";

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
