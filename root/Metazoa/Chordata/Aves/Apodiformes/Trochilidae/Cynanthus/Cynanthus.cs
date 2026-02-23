using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Cynanthus;

/// <summary>
/// Abstract class for Cynanthus (genus).
/// NCBI TaxId: 501308
/// </summary>
public abstract class Cynanthus : Trochilidae, ICynanthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cynanthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 501308;

    /// <inheritdoc />
    public virtual string GenusName => "Cynanthus";

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
