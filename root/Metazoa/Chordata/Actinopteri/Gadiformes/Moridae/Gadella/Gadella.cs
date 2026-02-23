using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Moridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Moridae.Gadella;

/// <summary>
/// Abstract class for Gadella (genus).
/// NCBI TaxId: 390692
/// </summary>
public abstract class Gadella : Moridae, IGadella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gadella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 390692;

    /// <inheritdoc />
    public virtual string GenusName => "Gadella";

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
