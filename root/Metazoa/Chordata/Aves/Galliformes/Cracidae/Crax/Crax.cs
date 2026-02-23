using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Cracidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Cracidae.Crax;

/// <summary>
/// Abstract class for Crax (genus).
/// NCBI TaxId: 83282
/// </summary>
public abstract class Crax : Cracidae, ICrax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Crax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 83282;

    /// <inheritdoc />
    public virtual string GenusName => "Crax";

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
