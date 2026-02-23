using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ateleopodiformes.Ateleopodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ateleopodiformes.Ateleopodidae.Ateleopus;

/// <summary>
/// Abstract class for Ateleopus (genus).
/// NCBI TaxId: 143305
/// </summary>
public abstract class Ateleopus : Ateleopodidae, IAteleopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ateleopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143305;

    /// <inheritdoc />
    public virtual string GenusName => "Ateleopus";

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
