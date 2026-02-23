using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Ingerophrynus;

/// <summary>
/// Abstract class for Ingerophrynus (genus).
/// NCBI TaxId: 651658
/// </summary>
public abstract class Ingerophrynus : Bufonidae, IIngerophrynus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ingerophrynus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 651658;

    /// <inheritdoc />
    public virtual string GenusName => "Ingerophrynus";

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
