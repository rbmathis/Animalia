using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Vandijkophrynus;

/// <summary>
/// Abstract class for Vandijkophrynus (genus).
/// NCBI TaxId: 651669
/// </summary>
public abstract class Vandijkophrynus : Bufonidae, IVandijkophrynus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Vandijkophrynus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 651669;

    /// <inheritdoc />
    public virtual string GenusName => "Vandijkophrynus";

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
