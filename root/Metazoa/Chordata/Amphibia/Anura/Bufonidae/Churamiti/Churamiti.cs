using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Churamiti;

/// <summary>
/// Abstract class for Churamiti (genus).
/// NCBI TaxId: 655849
/// </summary>
public abstract class Churamiti : Bufonidae, IChuramiti
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Churamiti";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 655849;

    /// <inheritdoc />
    public virtual string GenusName => "Churamiti";

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
