using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Beduka;

/// <summary>
/// Abstract class for Beduka (genus).
/// NCBI TaxId: 3049289
/// </summary>
public abstract class Beduka : Bufonidae, IBeduka
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Beduka";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3049289;

    /// <inheritdoc />
    public virtual string GenusName => "Beduka";

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
