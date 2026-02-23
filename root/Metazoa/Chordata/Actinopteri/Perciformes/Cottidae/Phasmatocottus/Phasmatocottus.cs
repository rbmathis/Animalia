using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Phasmatocottus;

/// <summary>
/// Abstract class for Phasmatocottus (genus).
/// NCBI TaxId: 1633517
/// </summary>
public abstract class Phasmatocottus : Cottidae, IPhasmatocottus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phasmatocottus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1633517;

    /// <inheritdoc />
    public virtual string GenusName => "Phasmatocottus";

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
