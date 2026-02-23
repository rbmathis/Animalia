using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rheobatrachidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rheobatrachidae.Rheobatrachus;

/// <summary>
/// Abstract class for Rheobatrachus (genus).
/// NCBI TaxId: 326984
/// </summary>
public abstract class Rheobatrachus : Rheobatrachidae, IRheobatrachus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rheobatrachus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 326984;

    /// <inheritdoc />
    public virtual string GenusName => "Rheobatrachus";

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
