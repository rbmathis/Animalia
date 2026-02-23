using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Abyssocottus;

/// <summary>
/// Abstract class for Abyssocottus (genus).
/// NCBI TaxId: 61636
/// </summary>
public abstract class Abyssocottus : Cottidae, IAbyssocottus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Abyssocottus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 61636;

    /// <inheritdoc />
    public virtual string GenusName => "Abyssocottus";

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
