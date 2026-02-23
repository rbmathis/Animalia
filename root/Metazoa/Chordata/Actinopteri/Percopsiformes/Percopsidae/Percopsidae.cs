using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Percopsiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Percopsiformes.Percopsidae;

/// <summary>
/// Abstract class for Percopsidae (family).
/// NCBI TaxId: 81379
/// </summary>
public abstract class Percopsidae : Percopsiformes, IPercopsidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Percopsidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "family";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 81379;

    /// <inheritdoc />
    public virtual string FamilyName => "Canidae";

    /// <inheritdoc />
    public virtual string[] FamilyCharacteristics => new[]
    {
        "Long muzzle",
        "Non-retractable claws",
        "Digitigrade stance",
        "Bushy tail",
        "Social behavior common"
    };

    /// <inheritdoc />
    public virtual bool HasNonRetractableClaws => true;

    /// <inheritdoc />
    public virtual bool IsDigitigrade => true;

    /// <inheritdoc />
    public virtual int FrontToeCount => 5;

    /// <inheritdoc />
    public virtual int HindToeCount => 4;

    /// <inheritdoc />
    public virtual string[] CommunicationMethods => new[]
    {
        "Vocalizations (howling, barking, whimpering)",
        "Body language",
        "Scent marking",
        "Facial expressions"
    };

}
