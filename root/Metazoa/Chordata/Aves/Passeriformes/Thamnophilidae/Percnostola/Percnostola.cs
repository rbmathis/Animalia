using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Percnostola;

/// <summary>
/// Abstract class for Percnostola (genus).
/// NCBI TaxId: 324748
/// </summary>
public abstract class Percnostola : Thamnophilidae, IPercnostola
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Percnostola";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 324748;

    /// <inheritdoc />
    public virtual string GenusName => "Percnostola";

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
