using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Cymolutes;

/// <summary>
/// Abstract class for Cymolutes (genus).
/// NCBI TaxId: 241283
/// </summary>
public abstract class Cymolutes : Labridae, ICymolutes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cymolutes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241283;

    /// <inheritdoc />
    public virtual string GenusName => "Cymolutes";

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
