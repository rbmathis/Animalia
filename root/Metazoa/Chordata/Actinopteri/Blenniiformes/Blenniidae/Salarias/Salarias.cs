using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Salarias;

/// <summary>
/// Abstract class for Salarias (genus).
/// NCBI TaxId: 94311
/// </summary>
public abstract class Salarias : Blenniidae, ISalarias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Salarias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 94311;

    /// <inheritdoc />
    public virtual string GenusName => "Salarias";

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
