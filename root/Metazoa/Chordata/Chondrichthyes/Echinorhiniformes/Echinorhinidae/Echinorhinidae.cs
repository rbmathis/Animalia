using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Echinorhiniformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Echinorhiniformes.Echinorhinidae;

/// <summary>
/// Abstract class for Echinorhinidae (family).
/// NCBI TaxId: 7832
/// </summary>
public abstract class Echinorhinidae : Echinorhiniformes, IEchinorhinidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Echinorhinidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "family";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7832;

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
