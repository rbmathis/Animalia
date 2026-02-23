using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Ichthyophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Ichthyophiidae.Caudacaecilia;

/// <summary>
/// Abstract class for Caudacaecilia (genus).
/// NCBI TaxId: 420443
/// </summary>
public abstract class Caudacaecilia : Ichthyophiidae, ICaudacaecilia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Caudacaecilia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 420443;

    /// <inheritdoc />
    public virtual string GenusName => "Caudacaecilia";

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
