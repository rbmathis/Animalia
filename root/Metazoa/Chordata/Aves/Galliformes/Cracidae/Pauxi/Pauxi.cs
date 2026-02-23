using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Cracidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Cracidae.Pauxi;

/// <summary>
/// Abstract class for Pauxi (genus).
/// NCBI TaxId: 125069
/// </summary>
public abstract class Pauxi : Cracidae, IPauxi
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pauxi";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 125069;

    /// <inheritdoc />
    public virtual string GenusName => "Pauxi";

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
