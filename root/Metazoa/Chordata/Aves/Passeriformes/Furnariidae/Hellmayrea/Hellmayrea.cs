using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Hellmayrea;

/// <summary>
/// Abstract class for Hellmayrea (genus).
/// NCBI TaxId: 86278
/// </summary>
public abstract class Hellmayrea : Furnariidae, IHellmayrea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hellmayrea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 86278;

    /// <inheritdoc />
    public virtual string GenusName => "Hellmayrea";

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
