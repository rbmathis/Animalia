using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Osornophryne;

/// <summary>
/// Abstract class for Osornophryne (genus).
/// NCBI TaxId: 47583
/// </summary>
public abstract class Osornophryne : Bufonidae, IOsornophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Osornophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 47583;

    /// <inheritdoc />
    public virtual string GenusName => "Osornophryne";

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
