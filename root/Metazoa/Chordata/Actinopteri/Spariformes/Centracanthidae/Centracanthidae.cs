using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Centracanthidae;

/// <summary>
/// Abstract class for Centracanthidae (family).
/// NCBI TaxId: 98821
/// </summary>
public abstract class Centracanthidae : Spariformes, ICentracanthidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Centracanthidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "family";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 98821;

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
