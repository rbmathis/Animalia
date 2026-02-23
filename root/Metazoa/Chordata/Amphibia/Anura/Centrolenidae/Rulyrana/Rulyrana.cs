using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Centrolenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Centrolenidae.Rulyrana;

/// <summary>
/// Abstract class for Rulyrana (genus).
/// NCBI TaxId: 715387
/// </summary>
public abstract class Rulyrana : Centrolenidae, IRulyrana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rulyrana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 715387;

    /// <inheritdoc />
    public virtual string GenusName => "Rulyrana";

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
