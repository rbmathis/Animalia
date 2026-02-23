using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acanthuriformes.Acanthuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acanthuriformes.Acanthuridae.Prionurus;

/// <summary>
/// Abstract class for Prionurus (genus).
/// NCBI TaxId: 75035
/// </summary>
public abstract class Prionurus : Acanthuridae, IPrionurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Prionurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 75035;

    /// <inheritdoc />
    public virtual string GenusName => "Prionurus";

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
