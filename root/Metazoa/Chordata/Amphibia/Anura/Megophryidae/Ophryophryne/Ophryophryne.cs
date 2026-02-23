using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae.Ophryophryne;

/// <summary>
/// Abstract class for Ophryophryne (genus).
/// NCBI TaxId: 283216
/// </summary>
public abstract class Ophryophryne : Megophryidae, IOphryophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ophryophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 283216;

    /// <inheritdoc />
    public virtual string GenusName => "Ophryophryne";

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
