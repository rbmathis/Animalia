using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Cracidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Cracidae.Penelope;

/// <summary>
/// Abstract class for Penelope (genus).
/// NCBI TaxId: 8985
/// </summary>
public abstract class Penelope : Cracidae, IPenelope
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Penelope";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8985;

    /// <inheritdoc />
    public virtual string GenusName => "Penelope";

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
