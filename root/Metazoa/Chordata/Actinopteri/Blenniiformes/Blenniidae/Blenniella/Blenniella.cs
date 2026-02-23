using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Blenniella;

/// <summary>
/// Abstract class for Blenniella (genus).
/// NCBI TaxId: 879711
/// </summary>
public abstract class Blenniella : Blenniidae, IBlenniella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Blenniella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 879711;

    /// <inheritdoc />
    public virtual string GenusName => "Blenniella";

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
