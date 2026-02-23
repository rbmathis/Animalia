using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Balistidae;

/// <summary>
/// Abstract class for Balistidae (family).
/// NCBI TaxId: 31024
/// </summary>
public abstract class Balistidae : Tetraodontiformes, IBalistidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Balistidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "family";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 31024;

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
