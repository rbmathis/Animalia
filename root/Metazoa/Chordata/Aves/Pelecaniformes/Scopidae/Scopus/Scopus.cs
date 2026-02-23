using AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Scopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Scopidae.Scopus;

/// <summary>
/// Abstract class for Scopus (genus).
/// NCBI TaxId: 33580
/// </summary>
public abstract class Scopus : Scopidae, IScopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 33580;

    /// <inheritdoc />
    public virtual string GenusName => "Scopus";

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
