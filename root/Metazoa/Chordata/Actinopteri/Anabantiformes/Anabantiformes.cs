using AnimalKingdom.root.Metazoa.Chordata.Actinopteri;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes;

/// <summary>
/// Abstract class for Anabantiformes (order).
/// NCBI TaxId: 1489900
/// </summary>
public abstract class Anabantiformes : Actinopteri, IAnabantiformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anabantiformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "order";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1489900;

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
