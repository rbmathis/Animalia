using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Priacanthiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Priacanthiformes.Cepolidae_in_ray_finned_fishes;

/// <summary>
/// Abstract class for Cepolidae (in: ray-finned fishes) (family).
/// NCBI TaxId: 270595
/// </summary>
public abstract class Cepolidae_in_ray_finned_fishes : Priacanthiformes, ICepolidae_in_ray_finned_fishes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cepolidae (in: ray-finned fishes)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "family";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 270595;

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
