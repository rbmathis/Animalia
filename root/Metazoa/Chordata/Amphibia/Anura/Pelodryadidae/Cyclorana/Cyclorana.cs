using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Cyclorana;

/// <summary>
/// Abstract class for Cyclorana (genus).
/// NCBI TaxId: 317312
/// </summary>
public abstract class Cyclorana : Pelodryadidae, ICyclorana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cyclorana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 317312;

    /// <inheritdoc />
    public virtual string GenusName => "Cyclorana";

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
