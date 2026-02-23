using AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Alcedinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Alcedinidae.Syma;

/// <summary>
/// Abstract class for Syma (genus).
/// NCBI TaxId: 342384
/// </summary>
public abstract class Syma : Alcedinidae, ISyma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Syma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 342384;

    /// <inheritdoc />
    public virtual string GenusName => "Syma";

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
