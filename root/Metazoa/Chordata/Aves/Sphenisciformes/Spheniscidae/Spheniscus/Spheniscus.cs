using AnimalKingdom.root.Metazoa.Chordata.Aves.Sphenisciformes.Spheniscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Sphenisciformes.Spheniscidae.Spheniscus;

/// <summary>
/// Abstract class for Spheniscus (genus).
/// NCBI TaxId: 9239
/// </summary>
public abstract class Spheniscus : Spheniscidae, ISpheniscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Spheniscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9239;

    /// <inheritdoc />
    public virtual string GenusName => "Spheniscus";

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
