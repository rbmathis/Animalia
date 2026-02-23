using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Werneria;

/// <summary>
/// Abstract class for Werneria (genus).
/// NCBI TaxId: 356335
/// </summary>
public abstract class Werneria : Bufonidae, IWerneria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Werneria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 356335;

    /// <inheritdoc />
    public virtual string GenusName => "Werneria";

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
