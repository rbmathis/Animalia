using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Bassozetus;

/// <summary>
/// Abstract class for Bassozetus (genus).
/// NCBI TaxId: 181396
/// </summary>
public abstract class Bassozetus : Ophidiidae, IBassozetus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bassozetus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 181396;

    /// <inheritdoc />
    public virtual string GenusName => "Bassozetus";

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
