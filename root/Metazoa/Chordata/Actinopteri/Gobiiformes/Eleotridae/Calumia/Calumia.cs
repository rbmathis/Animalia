using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Calumia;

/// <summary>
/// Abstract class for Calumia (genus).
/// NCBI TaxId: 86227
/// </summary>
public abstract class Calumia : Eleotridae, ICalumia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Calumia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 86227;

    /// <inheritdoc />
    public virtual string GenusName => "Calumia";

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
