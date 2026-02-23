using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Evermannellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Evermannellidae.Coccorella;

/// <summary>
/// Abstract class for Coccorella (genus).
/// NCBI TaxId: 172146
/// </summary>
public abstract class Coccorella : Evermannellidae, ICoccorella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Coccorella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 172146;

    /// <inheritdoc />
    public virtual string GenusName => "Coccorella";

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
