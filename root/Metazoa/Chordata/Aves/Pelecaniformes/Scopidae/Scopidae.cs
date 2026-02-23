using AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Scopidae;

/// <summary>
/// Abstract class for Scopidae (family).
/// NCBI TaxId: 33579
/// </summary>
public abstract class Scopidae : Pelecaniformes, IScopidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scopidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "family";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 33579;

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
