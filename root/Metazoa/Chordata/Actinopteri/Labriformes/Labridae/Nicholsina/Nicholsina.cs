using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Nicholsina;

/// <summary>
/// Abstract class for Nicholsina (genus).
/// NCBI TaxId: 59658
/// </summary>
public abstract class Nicholsina : Labridae, INicholsina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nicholsina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 59658;

    /// <inheritdoc />
    public virtual string GenusName => "Nicholsina";

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
