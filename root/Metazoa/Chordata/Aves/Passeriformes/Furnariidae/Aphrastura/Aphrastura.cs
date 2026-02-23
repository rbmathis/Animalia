using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Aphrastura;

/// <summary>
/// Abstract class for Aphrastura (genus).
/// NCBI TaxId: 307075
/// </summary>
public abstract class Aphrastura : Furnariidae, IAphrastura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aphrastura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 307075;

    /// <inheritdoc />
    public virtual string GenusName => "Aphrastura";

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
