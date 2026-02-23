using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Nemipteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Nemipteridae.Pentapodus;

/// <summary>
/// Abstract class for Pentapodus (genus).
/// NCBI TaxId: 390361
/// </summary>
public abstract class Pentapodus : Nemipteridae, IPentapodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pentapodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 390361;

    /// <inheritdoc />
    public virtual string GenusName => "Pentapodus";

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
