using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Eugenes;

/// <summary>
/// Abstract class for Eugenes (genus).
/// NCBI TaxId: 304845
/// </summary>
public abstract class Eugenes : Trochilidae, IEugenes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eugenes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 304845;

    /// <inheritdoc />
    public virtual string GenusName => "Eugenes";

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
