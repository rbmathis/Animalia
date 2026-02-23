using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Poyntonophrynus;

/// <summary>
/// Abstract class for Poyntonophrynus (genus).
/// NCBI TaxId: 651676
/// </summary>
public abstract class Poyntonophrynus : Bufonidae, IPoyntonophrynus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Poyntonophrynus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 651676;

    /// <inheritdoc />
    public virtual string GenusName => "Poyntonophrynus";

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
