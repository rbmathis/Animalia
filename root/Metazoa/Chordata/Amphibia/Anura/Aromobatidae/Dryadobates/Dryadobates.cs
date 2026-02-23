using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Aromobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Aromobatidae.Dryadobates;

/// <summary>
/// Abstract class for Dryadobates (genus).
/// NCBI TaxId: 3436071
/// </summary>
public abstract class Dryadobates : Aromobatidae, IDryadobates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dryadobates";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3436071;

    /// <inheritdoc />
    public virtual string GenusName => "Dryadobates";

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
