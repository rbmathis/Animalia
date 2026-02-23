using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Hemigymnus;

/// <summary>
/// Abstract class for Hemigymnus (genus).
/// NCBI TaxId: 241302
/// </summary>
public abstract class Hemigymnus : Labridae, IHemigymnus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemigymnus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241302;

    /// <inheritdoc />
    public virtual string GenusName => "Hemigymnus";

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
