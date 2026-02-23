using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Claroteidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Claroteidae.Clarotes;

/// <summary>
/// Abstract class for Clarotes (genus).
/// NCBI TaxId: 103207
/// </summary>
public abstract class Clarotes : Claroteidae, IClarotes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Clarotes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 103207;

    /// <inheritdoc />
    public virtual string GenusName => "Clarotes";

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
