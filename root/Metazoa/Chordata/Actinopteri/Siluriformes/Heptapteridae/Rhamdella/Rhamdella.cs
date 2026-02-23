using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae.Rhamdella;

/// <summary>
/// Abstract class for Rhamdella (genus).
/// NCBI TaxId: 1385671
/// </summary>
public abstract class Rhamdella : Heptapteridae, IRhamdella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhamdella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1385671;

    /// <inheritdoc />
    public virtual string GenusName => "Rhamdella";

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
