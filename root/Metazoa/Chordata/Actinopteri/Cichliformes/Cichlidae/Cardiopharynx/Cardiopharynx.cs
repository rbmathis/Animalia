using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Cardiopharynx;

/// <summary>
/// Abstract class for Cardiopharynx (genus).
/// NCBI TaxId: 27736
/// </summary>
public abstract class Cardiopharynx : Cichlidae, ICardiopharynx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cardiopharynx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27736;

    /// <inheritdoc />
    public virtual string GenusName => "Cardiopharynx";

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
