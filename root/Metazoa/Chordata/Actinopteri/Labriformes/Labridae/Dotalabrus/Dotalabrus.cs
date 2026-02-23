using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Dotalabrus;

/// <summary>
/// Abstract class for Dotalabrus (genus).
/// NCBI TaxId: 2986111
/// </summary>
public abstract class Dotalabrus : Labridae, IDotalabrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dotalabrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2986111;

    /// <inheritdoc />
    public virtual string GenusName => "Dotalabrus";

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
