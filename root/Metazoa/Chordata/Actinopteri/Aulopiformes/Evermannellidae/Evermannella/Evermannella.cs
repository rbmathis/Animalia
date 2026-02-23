using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Evermannellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Evermannellidae.Evermannella;

/// <summary>
/// Abstract class for Evermannella (genus).
/// NCBI TaxId: 172144
/// </summary>
public abstract class Evermannella : Evermannellidae, IEvermannella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Evermannella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 172144;

    /// <inheritdoc />
    public virtual string GenusName => "Evermannella";

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
