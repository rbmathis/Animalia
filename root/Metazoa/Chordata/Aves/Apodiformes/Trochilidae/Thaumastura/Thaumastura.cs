using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Thaumastura;

/// <summary>
/// Abstract class for Thaumastura (genus).
/// NCBI TaxId: 689307
/// </summary>
public abstract class Thaumastura : Trochilidae, IThaumastura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thaumastura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 689307;

    /// <inheritdoc />
    public virtual string GenusName => "Thaumastura";

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
