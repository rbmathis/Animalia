using AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Alcedinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Alcedinidae.Pelargopsis;

/// <summary>
/// Abstract class for Pelargopsis (genus).
/// NCBI TaxId: 342364
/// </summary>
public abstract class Pelargopsis : Alcedinidae, IPelargopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pelargopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 342364;

    /// <inheritdoc />
    public virtual string GenusName => "Pelargopsis";

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
