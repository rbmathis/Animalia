using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acanthuriformes.Acanthuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acanthuriformes.Acanthuridae.Ctenochaetus;

/// <summary>
/// Abstract class for Ctenochaetus (genus).
/// NCBI TaxId: 75019
/// </summary>
public abstract class Ctenochaetus : Acanthuridae, ICtenochaetus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ctenochaetus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 75019;

    /// <inheritdoc />
    public virtual string GenusName => "Ctenochaetus";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
