using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Rostratulidae;

/// <summary>
/// Abstract class for Rostratulidae (family).
/// NCBI TaxId: 118791
/// </summary>
public abstract class Rostratulidae : Charadriiformes, IRostratulidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rostratulidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "family";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 118791;

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
