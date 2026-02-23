using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Coeligena;

/// <summary>
/// Abstract class for Coeligena (genus).
/// NCBI TaxId: 56649
/// </summary>
public abstract class Coeligena : Trochilidae, ICoeligena
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Coeligena";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56649;

    /// <inheritdoc />
    public virtual string GenusName => "Coeligena";

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
