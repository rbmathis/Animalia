using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Cracidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Cracidae.Pipile;

/// <summary>
/// Abstract class for Pipile (genus).
/// NCBI TaxId: 125072
/// </summary>
public abstract class Pipile : Cracidae, IPipile
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pipile";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 125072;

    /// <inheritdoc />
    public virtual string GenusName => "Pipile";

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
