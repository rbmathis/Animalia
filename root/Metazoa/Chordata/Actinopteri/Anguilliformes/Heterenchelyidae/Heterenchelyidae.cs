using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Heterenchelyidae;

/// <summary>
/// Abstract class for Heterenchelyidae (family).
/// NCBI TaxId: 556143
/// </summary>
public abstract class Heterenchelyidae : Anguilliformes, IHeterenchelyidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heterenchelyidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "family";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 556143;

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
