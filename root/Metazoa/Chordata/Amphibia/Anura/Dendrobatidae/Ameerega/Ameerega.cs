using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae.Ameerega;

/// <summary>
/// Abstract class for Ameerega (genus).
/// NCBI TaxId: 507706
/// </summary>
public abstract class Ameerega : Dendrobatidae, IAmeerega
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ameerega";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 507706;

    /// <inheritdoc />
    public virtual string GenusName => "Ameerega";

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
