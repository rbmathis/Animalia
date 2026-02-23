using AnimalKingdom.root.Metazoa.Chordata.Aves;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Phoenicopteriformes;

/// <summary>
/// Abstract class for Phoenicopteriformes (order).
/// NCBI TaxId: 9214
/// </summary>
public abstract class Phoenicopteriformes : Aves, IPhoenicopteriformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phoenicopteriformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "order";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9214;

    /// <inheritdoc />
    public virtual string OrderName => "Carnivora";

    /// <inheritdoc />
    public virtual string[] OrderCharacteristics => new[]
    {
        "Carnassial teeth present",
        "Forward-facing eyes",
        "Strong jaw muscles",
        "Acute senses",
        "Retractable or non-retractable claws"
    };

    /// <inheritdoc />
    public virtual bool HasCarnassialTeeth => true;

    /// <inheritdoc />
    public virtual string DietType => "Carnivorous";

    /// <inheritdoc />
    public virtual string[] DigestiveAdaptations => new[]
    {
        "Short digestive tract",
        "Highly acidic stomach",
        "Simple stomach structure",
        "Efficient protein digestion"
    };

    /// <inheritdoc />
    public virtual string HuntingStrategy => "Pursuit predation";

    /// <inheritdoc />
    public virtual string[] PreyTypes => new[] { "Mammals", "Birds" };

    /// <inheritdoc />
    public virtual bool IsCooperativeHunter => false;

    /// <inheritdoc />
    public virtual string[] HuntingSensoryAdaptations => new[]
    {
        "Binocular vision",
        "Acute hearing",
        "Sensitive olfaction"
    };

}
