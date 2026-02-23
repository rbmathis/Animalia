using AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Alcedinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Alcedinidae.Cittura;

/// <summary>
/// Abstract class for Cittura (genus).
/// NCBI TaxId: 342382
/// </summary>
public abstract class Cittura : Alcedinidae, ICittura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cittura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 342382;

    /// <inheritdoc />
    public virtual string GenusName => "Cittura";

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
