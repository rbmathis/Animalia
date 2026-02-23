using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Aromobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Aromobatidae.Allobates;

/// <summary>
/// Abstract class for Allobates (genus).
/// NCBI TaxId: 384907
/// </summary>
public abstract class Allobates : Aromobatidae, IAllobates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Allobates";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 384907;

    /// <inheritdoc />
    public virtual string GenusName => "Allobates";

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
