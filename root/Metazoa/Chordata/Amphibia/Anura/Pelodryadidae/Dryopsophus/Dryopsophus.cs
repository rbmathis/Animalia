using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Dryopsophus;

/// <summary>
/// Abstract class for Dryopsophus (genus).
/// NCBI TaxId: 3680990
/// </summary>
public abstract class Dryopsophus : Pelodryadidae, IDryopsophus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dryopsophus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3680990;

    /// <inheritdoc />
    public virtual string GenusName => "Dryopsophus";

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
